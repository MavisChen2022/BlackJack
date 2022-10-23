using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    internal class Rule
    {
        public static bool Over(int point)
        {
            if (point > 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Winner(int player, int dealer)
        {
            if (player > dealer)
            {
                MessageBox.Show("You win!");
            }
            else
            {
                MessageBox.Show("Dealer win!");
            }
        }
        public static bool DealNotOver18(int point)
        {
            if (point <18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
