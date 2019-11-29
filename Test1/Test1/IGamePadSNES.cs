using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public interface IGamePadSNES : IGamePadNES
    {
        bool L { get; set; }
        bool R { get; set; }
        bool X { get; set; }
        bool Y { get; set; }
    }
}
