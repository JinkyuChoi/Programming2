using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LAB5
{
    public class DrawableLine : IDrawable
    {
        private Color _color;

        private Point _lineStart;

        private Point _lineEnd;
        public DrawableLine(Color color, Point start, Point end)
        {
            _color = color;
            _lineStart = start;
            _lineEnd = end;
        }

        public void Draw(IGraphics graphics)
        {
            Pen pen = new Pen(_color);
            graphics.DrawLine(pen, _lineStart, _lineEnd);
        }
    }
}
