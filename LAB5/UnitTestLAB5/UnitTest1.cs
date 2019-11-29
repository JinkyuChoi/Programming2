using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using LAB5;

namespace UnitTestLAB5
{
    public class FakeGraphics : IGraphics
    {
        public string MethodCalled { get; private set; }

        public void Dispose()
        {
            MethodCalled = "Dispose";
        }

        public void DrawBezier(Pen pen, Point point1, Point point2, Point point3, Point point4)
        {
            MethodCalled = "DrawBezier";
        }

        public void DrawEllipse(Pen pen, Rectangle rectangle)
        {
            MethodCalled = "DrawEllipse";
        }

        public void DrawLine(Pen pen, Point start, Point end)
        {
            MethodCalled = "DrawLine";
        }

        public void DrawRectangle(Pen pen, Rectangle rectangle)
        {
            MethodCalled = "DrawRectangle";
        }

        public void FillEllipse(SolidBrush solidBrush, Rectangle rectangle)
        {
            MethodCalled = "FillEllipse";
        }

        public void FillRectangle(SolidBrush solidBrush, Rectangle rectangle)
        {
            MethodCalled = "FillRectangle";
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Dispose()
        {
            //given
            FakeGraphics graphics = new FakeGraphics();

            //when
            graphics.Dispose();

            //then
            Assert.AreEqual("Dispose", graphics.MethodCalled);
        }

        [TestMethod]
        public void DrawBezier()
        {
            //given
            FakeGraphics graphics = new FakeGraphics();
            DrawableBezier bezier = new DrawableBezier(Color.Red, new Point(1, 1), new Point(2, 2), new Point(3,3), new Point(4,4));

            //when
            bezier.Draw(graphics);

            //then
            Assert.AreEqual("DrawBezier", graphics.MethodCalled);
        }

        [TestMethod]
        public void DrawEllipse()
        {
            //given
            FakeGraphics graphics = new FakeGraphics();
            DrawableEllipse ellipse  = new DrawableEllipse(Color.Red, false, new Rectangle());

            //when
            ellipse.Draw(graphics);

            //then
            Assert.AreEqual("DrawEllipse", graphics.MethodCalled);
        }

        [TestMethod]
        public void DrawLine()
        {
            //given
            FakeGraphics graphics = new FakeGraphics();
            DrawableLine line = new DrawableLine(Color.Red, new Point(1,1), new Point(2,2));

            //when
            line.Draw(graphics);

            //then
            Assert.AreEqual("DrawLine", graphics.MethodCalled);
        }

        [TestMethod]
        public void DrawRectangle()
        {
            //given
            FakeGraphics graphics = new FakeGraphics();
            DrawableRectangle rectangle = new DrawableRectangle(Color.Red, false, new Rectangle());

            //when
            rectangle.Draw(graphics);

            //then
            Assert.AreEqual("DrawRectangle", graphics.MethodCalled);
        }

        [TestMethod]
        public void FillEllipse()
        {
            //given
            FakeGraphics graphics = new FakeGraphics();
            DrawableEllipse ellipse = new DrawableEllipse(Color.Red, true, new Rectangle());

            //when
            ellipse.Draw(graphics);

            //then
            Assert.AreEqual("FillEllipse", graphics.MethodCalled);
        }

        [TestMethod]
        public void FillRectangle()
        {
            //given
            FakeGraphics graphics = new FakeGraphics();
            DrawableRectangle rectangle = new DrawableRectangle(Color.Red, true, new Rectangle());

            //when
            rectangle.Draw(graphics);

            //then
            Assert.AreEqual("FillRectangle", graphics.MethodCalled);
        }
    }
}
