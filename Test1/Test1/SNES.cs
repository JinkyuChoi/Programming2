using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class SNES
    {
        public SNESGame Game { get; set; }
        public IGamePadSNES GamePad { get; set; }

        public void Play()
        {
            Console.WriteLine($"Playing {Game.Name}");

            ConsoleKeyInfo input;
            do
            {
                UpdateDisplay();
                GamePad.Reset();
                input = Console.ReadKey(true);
                GamePad.SetInput(input.Key);

            } while (input.Key != ConsoleKey.Escape);
        }

        private void UpdateDisplay()
        {
            Console.Clear();
            Console.WriteLine($"Playing {Game.Name}");

            Console.Write("   _");
            Write("---", GamePad.L);
            Console.Write("______________");
            Write("---", GamePad.R);
            Console.WriteLine("_");
            Console.Write("  /  ");
            Write("_", GamePad.Up);
            Console.Write("                ");
            Write("_", GamePad.X);
            Console.WriteLine(@"  \");
            Console.Write(" / ");
            Write("_", GamePad.Left);
            Write("| |", GamePad.Up);
            Write("_", GamePad.Right);
            Console.Write("            ");
            Write("_", GamePad.Y);
            Write("|_|", GamePad.X);
            Write("_", GamePad.A);
            Console.WriteLine(@" \");
            Console.Write("| ");
            Write("|_", GamePad.Left);
            Console.Write(" O ");
            Write("_|", GamePad.Right);
            Console.Write("   // //  ");
            Write("|_|", GamePad.Y);
            Write("_", GamePad.B);
            Write("|_|", GamePad.A);
            Console.WriteLine(" |");
            Console.Write(@" \  ");
            Write("|_|", GamePad.Down);
            Console.Write("   ________   ");
            Write("|_|", GamePad.B);
            Console.WriteLine("  /");
            Console.WriteLine(@"  \______/        \______/");

            Console.Write("The last action was: ");
            if (GamePad.Up)
                Console.WriteLine(Game.UpAction);
            else if (GamePad.Down)
                Console.WriteLine(Game.DownAction);
            else if (GamePad.Left)
                Console.WriteLine(Game.LeftAction);
            else if (GamePad.Right)
                Console.WriteLine(Game.RightAction);
            else if (GamePad.A)
                Console.WriteLine(Game.AAction);
            else if (GamePad.B)
                Console.WriteLine(Game.BAction);
            else if (GamePad.X)
                Console.WriteLine(Game.XAction);
            else if (GamePad.Y)
                Console.WriteLine(Game.YAction);
            else if (GamePad.L)
                Console.WriteLine(Game.LAction);
            else if (GamePad.R)
                Console.WriteLine(Game.RAction);
            else
                Console.WriteLine();

            Console.WriteLine("\nPress a key to light up the controller (Esc to exit)");
        }

        public void Write(string text, bool pressed)
        {
            Console.ForegroundColor = pressed ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(text);
            Console.ResetColor();
        }
    }

}
