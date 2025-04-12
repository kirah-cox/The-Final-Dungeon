using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class Character
    {
        public string CharacterChar { get; set; }
        public int UpDown { get; set; }
        public int LeftRight { get; set; }
        public bool Up { get; set; }
        public bool Down { get; set; }
        public bool Left { get; set; }
        public bool Right { get; set; }

        public Character(string characterChar, int upDown = 1, int leftRight = 1)
        {
            CharacterChar = characterChar;
            UpDown = upDown;
            LeftRight = leftRight;
            Up = false;
            Down = false;
            Left = false;
            Right = false;
        }
    }
}
