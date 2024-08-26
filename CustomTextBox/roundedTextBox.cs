using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CustomTextBox
{
    internal class roundedTextBox
    {
        float radius;
        GraphicsPath myGrPath;
        float x, y;
        float width, height;

        public roundedTextBox(float width, float height, float radius, float x = 0f, float y = 0f)
        {
            this.radius = radius;
            this.myGrPath = new GraphicsPath();
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

            CreatePath();
        }

        void CreatePath()
        {
            if(radius <= 0f)
            {
                myGrPath.AddRectangle(new RectangleF(x, y, width, height));
            }
            else
            {
                float diameter = 2f * radius;
                myGrPath.AddArc(x, y, diameter, diameter, 180f, 90f);
                myGrPath.AddArc(width - diameter - 1f, y, diameter, diameter, 270f, 90f);
                myGrPath.AddArc(width - diameter - 1f, height - diameter - 1f, diameter, diameter, 0f, 90f);
                myGrPath.AddArc(x, height - diameter - 1f, diameter, diameter, 90f, 90f);
                myGrPath.CloseAllFigures();
            }
        }

        public GraphicsPath Path => myGrPath;

        public RectangleF Rect => new RectangleF(x, y, width, height);

        public float Radius
        {
            get => radius;
            set
            {
                radius = value;
                myGrPath.Reset();
                CreatePath();
            }
        }
    }
}
