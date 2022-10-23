using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Diamond
    {
        static List<string> diamond = new List<string>() { "empty", "♦1", "♦2", "♦3", "♦4", "♦5", "♦6", "♦7", "♦8", "♦9", "♦10", "♦J", "♦Q", "♦K" };
        public static Dictionary<string, int> diamondDict = new Dictionary<string, int>() { { "empty", 0 }, { "♦1", 1 }, { "♦2", 2 }, { "♦3", 3 }, { "♦4", 4 }, { "♦5", 5 }, { "♦6", 6 }, { "♦7", 7 }, { "♦8", 8 }, { "♦9", 9 }, { "♦10", 10 }, { "♦J", 10 }, { "♦Q", 10 }, { "♦K", 10 } };
        public static string result = "";
        public void Show(int num)
        {
            result = diamond[num];
        }
    }
}
