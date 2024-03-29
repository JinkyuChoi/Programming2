using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Super Mario Bros (NES)");
            Console.WriteLine("2 - Mega Man (NES)");
            Console.WriteLine("3 - Super Mario Kart (SNES)");
            Console.WriteLine("4 - A Link To The Past (SNES)");
            Console.Write("Which game would you like to play? ");

            NES nes = new NES();
            SNES snes = new SNES();

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    nes.Game = new NESGame();
                    nes.GamePad = new GamePadNES();
                    nes.Game.Load("SuperMarioBros.txt");
                    nes.Play();
                    break;
                case "2":
                    nes.Game = new NESGame();
                    nes.GamePad = new GamePadNES();
                    nes.Game.Load("MegaMan.txt");
                    nes.Play();
                    break;
                case "3":
                    snes.Game = new SNESGame();
                    snes.GamePad = new GamePadSNES();
                    snes.Game.Load("SuperMarioKart.txt");
                    snes.Play();
                    break;
                case "4":
                    snes.Game = new SNESGame();
                    snes.GamePad = new GamePadSNES();
                    snes.Game.Load("ALinkToThePast.txt");
                    snes.Play();
                    break;
            }
        }
    }
}
