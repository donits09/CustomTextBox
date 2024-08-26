namespace CustomTextBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedTextBoxMain1 = new CustomTextBox.roundedTextBoxMain();
            this.roundedTextBoxMain2 = new CustomTextBox.roundedTextBoxMain();
            this.roundedTextBoxMain3 = new CustomTextBox.roundedTextBoxMain();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roundedTextBoxMain1
            // 
            this.roundedTextBoxMain1.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextBoxMain1.Br = System.Drawing.Color.White;
            this.roundedTextBoxMain1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.roundedTextBoxMain1.ForeColor = System.Drawing.Color.Black;
            this.roundedTextBoxMain1.Location = new System.Drawing.Point(173, 34);
            this.roundedTextBoxMain1.Name = "roundedTextBoxMain1";
            this.roundedTextBoxMain1.Size = new System.Drawing.Size(230, 33);
            this.roundedTextBoxMain1.TabIndex = 0;
            // 
            // roundedTextBoxMain2
            // 
            this.roundedTextBoxMain2.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextBoxMain2.Br = System.Drawing.Color.White;
            this.roundedTextBoxMain2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.roundedTextBoxMain2.ForeColor = System.Drawing.Color.Black;
            this.roundedTextBoxMain2.Location = new System.Drawing.Point(173, 87);
            this.roundedTextBoxMain2.Name = "roundedTextBoxMain2";
            this.roundedTextBoxMain2.Size = new System.Drawing.Size(230, 33);
            this.roundedTextBoxMain2.TabIndex = 1;
            // 
            // roundedTextBoxMain3
            // 
            this.roundedTextBoxMain3.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextBoxMain3.Br = System.Drawing.Color.White;
            this.roundedTextBoxMain3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.roundedTextBoxMain3.ForeColor = System.Drawing.Color.Black;
            this.roundedTextBoxMain3.Location = new System.Drawing.Point(173, 140);
            this.roundedTextBoxMain3.Name = "roundedTextBoxMain3";
            this.roundedTextBoxMain3.Size = new System.Drawing.Size(230, 33);
            this.roundedTextBoxMain3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Re-type Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 204);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedTextBoxMain3);
            this.Controls.Add(this.roundedTextBoxMain2);
            this.Controls.Add(this.roundedTextBoxMain1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private roundedTextBoxMain roundedTextBoxMain1;
        private roundedTextBoxMain roundedTextBoxMain2;
        private roundedTextBoxMain roundedTextBoxMain3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

