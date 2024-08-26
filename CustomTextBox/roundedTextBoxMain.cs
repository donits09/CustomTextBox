using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CustomTextBox
{
    internal class roundedTextBoxMain : Control
    {
        int radius = 10;
        public TextBox rounded_textbox = new TextBox();
        GraphicsPath shape;
        GraphicsPath innerRect;
        Color br;

        public roundedTextBoxMain()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            this.rounded_textbox.Parent = this;
            base.Controls.Add(this.rounded_textbox);
            this.rounded_textbox.BorderStyle = BorderStyle.None;
            rounded_textbox.Font = this.Font;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Black;
            this.br = Color.White;
            rounded_textbox.BackColor = this.br;
            this.Text = null;
            this.Font = new Font("Century Gothic", 12f);
            base.Size = new Size(135, 33);
            this.DoubleBuffered = true;
            rounded_textbox.KeyDown += new KeyEventHandler(rounded_textbox_KeyDown);
            rounded_textbox.TextChanged += new EventHandler(rounded_textbox_TextChanged);
            rounded_textbox.MouseDoubleClick += new MouseEventHandler(rounded_textbox_MouseDoubleClick);
        }

        private void rounded_textbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                rounded_textbox.SelectAll();
            }
        }

        private void rounded_textbox_TextChanged(object sender, EventArgs e)
        {
            this.Text = rounded_textbox.Text;
        }

        private void rounded_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && (e.KeyCode == Keys.A))
            {
                rounded_textbox.SelectionStart = 0;
                rounded_textbox.SelectionLength = this.Text.Length;
            }
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            rounded_textbox.ForeColor = this.ForeColor;
            base.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.shape = new roundedTextBox((float)base.Width, (float)base.Height, (float)this.radius, 0f, 0f).Path;
            this.innerRect = new roundedTextBox(base.Width - 0.5f, base.Height - 0.5f, (float)this.radius, 0.5f, 0.5f).Path;
            if(rounded_textbox.Height >= (base.Height - 4))
            {
                base.Height = rounded_textbox.Height + 4;
            }
            rounded_textbox.Location = new Point(this.radius - 5, (base.Height / 2) - (rounded_textbox.Font.Height / 2));
            rounded_textbox.Width = base.Width - ((int)(this.radius * 1.5));
            e.Graphics.SmoothingMode = ((SmoothingMode)SmoothingMode.HighQuality);
            Bitmap bitmap = new Bitmap(base.Width, base.Height);
            Graphics graphics = Graphics.FromImage((Image)bitmap);
            e.Graphics.DrawPath(Pens.Gray, this.shape);
            using(SolidBrush brush = new SolidBrush(this.br))
            {
                e.Graphics.FillPath((Brush)brush, this.innerRect);
            }
            Transparent.textBoxTransparent(this, e.Graphics);
            base.OnPaint(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            rounded_textbox.Text = this.Text;
        }

        public void SelectAll()
        {
            rounded_textbox.SelectAll();
        }

        public Color Br
        {
            get => this.br;
            set
            {
                this.br = value;
                if(this.br != Color.Transparent)
                {
                    rounded_textbox.BackColor = this.br;
                }
                base.Invalidate();
            }
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = Color.Transparent;
        }
    }
}
