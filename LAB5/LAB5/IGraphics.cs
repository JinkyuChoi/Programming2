using System;
using System.Drawing;

namespace LAB5
{
    public interface IGraphics : IDisposable
    {
        void DrawLine(Pen pen, Point start, Point end);
        void DrawRectangle(Pen pen, Rectangle rectangle);
        void DrawEllipse(Pen pen, Rectangle rectangle);
        void DrawBezier(Pen pen, Point point1, Point point2, Point point3, Point point4);
        void FillRectangle(SolidBrush solidBrush, Rectangle rectangle);
        void FillEllipse(SolidBrush solidBrush, Rectangle rectangle);
    }
}