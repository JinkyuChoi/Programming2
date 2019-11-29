﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LAB5
{
    public class DrawableRectangle : Primitive, IDrawable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle) : base(color, filled, rectangle)
        {
            _color = color;
            _filled = filled;
            _boundingRectangle = rectangle;
        }
        public void Draw(IGraphics graphics)
        {
            if(_filled == true)
            {
                SolidBrush solidBrush = new SolidBrush(_color);
                graphics.FillRectangle(solidBrush, _boundingRectangle);
            }
            else
            {
                Pen pen = new Pen(_color);
                graphics.DrawRectangle(pen, _boundingRectangle);
            }
        }
    }
}
