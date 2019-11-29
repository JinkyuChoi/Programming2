using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class GamePadSNES : GamePadNES, IGamePadSNES
    {
        public bool L { get; set; }
        public bool R { get; set; }
        public bool X { get; set; }
        public bool Y { get; set; }

        public override void Reset()
        { 
            A = false;
            B = false;
            Down = false;
            Left = false;
            Right = false;
            Up = false;
            L = false;
            R = false;
            X = false;
            Y = false;
        }

        public override void SetInput(ConsoleKey key)
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
                case ConsoleKey.L:
                    L = true;
                    break;
                case ConsoleKey.R:
                    R = true;
                    break;
                case ConsoleKey.X:
                    X = true;
                    break;
                case ConsoleKey.Y:
                    Y = true;
                    break;
            }
        }
    }
}
