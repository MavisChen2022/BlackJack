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
        public static bool ChickenDinner(List<string> now,string ace,string jqk)
        {
            if(now.Count==2)
            {
                if(now.Contains(ace))
                {
                    if(now.Contains(jqk))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if(now.Contains(jqk))
                {
                    if (now.Contains(ace))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false ;
            }
        }
    }
}
