using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class CharacterRanges
    {
        public char Floor { get; }
        public char Ceiling { get; }
        public CharacterRanges(char floor, char ceiling)
        {
            Floor = floor;
            Ceiling = ceiling;
        }
    }
}
