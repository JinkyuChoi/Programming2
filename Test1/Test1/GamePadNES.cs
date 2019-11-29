using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class GamePadNES : IGamePadNES
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool Down { get; set; }
        public bool Left { get; set; }
        public bool Right { get; set; }
        public bool Up { get; set; }

        public virtual void Reset()
        {
            A = false;
            B = false;
            Down = false;
            Left = false;
            Right = false;
            Up = false;
        }

        public virtual void SetInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.A:
                    A = true;
                    break;
                case ConsoleKey.B:
                    B = true;
                    break;
                case ConsoleKey.DownArrow:
                    Down = true;
                    break;
                case ConsoleKey.LeftArrow:
                    Left = true;
                    break;
                case ConsoleKey.RightArrow:
                    Right = true;
                    break;
                case ConsoleKey.UpArrow:
                    Up = true;
                    break;
            }
        }
    }
}
