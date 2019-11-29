using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LAB5
{
    public abstract class Primitive
    {
        protected Color _color;

        protected bool _filled;

        protected Rectangle _boundingRectangle;
        public Primitive(Color color, bool filled, Rectangle rectangle)
        {
            _color = color;
            _filled = filled;
            _boundingRectangle = rectangle;
        }
    }
}
