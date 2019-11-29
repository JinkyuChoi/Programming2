using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public interface IGamePadNES : IGamePad
    {
        bool A { get; set; }
        bool B { get; set; }
        bool Down { get; set; }
        bool Left { get; set; }
        bool Right { get; set; }
        bool Up { get; set; }
    }
}
