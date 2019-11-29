using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LAB5
{
    public class DrawableBezier : IDrawable
    {
        private Color _color;

        private Point _curveStart;

        private Point _controlFirst;

        private Point _controlSecond;

        private Point _curveEnd;
        public DrawableBezier(Color color, Point start, Point first, Point second, Point end)
        {
            _color = color;
            _curveStart = start;
            _controlFirst = first;
            _controlSecond = second;
            _curveEnd = end;
        }

        public void Draw(IGraphics graphics)
        {
            Pen pen = new Pen(_color);
            graphics.DrawBezier(pen, _curveStart, _controlFirst, _controlSecond, _curveEnd);
        }
    }
}

