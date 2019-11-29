using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test1
{
    public class NESGame
    {
        public string AAction { get; set; }
        public string BAction { get; set; }
        public string DownAction { get; set; }
        public string LeftAction { get; set; }
        public string Name { get; set; }
        public string RightAction { get; set; }
        public string UpAction { get; set; }

        public virtual void Load(string gameFile)
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
            }
        }
    }
}
