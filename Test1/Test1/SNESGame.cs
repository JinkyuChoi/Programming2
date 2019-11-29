using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test1
{
    public class SNESGame : NESGame
    {
        public string LAction { get; set; }
        public string RAction { get; set; }
        public string XAction { get; set; }
        public string YAction { get; set; }

        public override void Load(string gameFile)
        {
            using (StreamReader reader = new StreamReader(gameFile))
            {
                 Name = reader.ReadLine();
                 UpAction = reader.ReadLine();
                 DownAction = reader.ReadLine();
                 LeftAction = reader.ReadLine();
                 RightAction = reader.ReadLine();
                 AAction = reader.ReadLine();
                 BAction = reader.ReadLine();
                 XAction = reader.ReadLine();
                 YAction = reader.ReadLine();
                 LAction = reader.ReadLine();
                 RAction = reader.ReadLine();
            }
        }
    }
}
