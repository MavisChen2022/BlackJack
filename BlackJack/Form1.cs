using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        static string[] emptyPoker = new string[52];
        static int count=0;
        static int num = 0;
        static int correspondPoint = 0;
        static List<string> playerNow=new List<string>();
        static List<string> DealerNow = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        public void ChooseCard()
        {
            Random randomColor = new Random();
            Random randomNumber = new Random();
            Spade spade = new Spade();
            Heart heart = new Heart();
            Diamond diamond = new Diamond();
            Club club = new Club();
            int color = randomColor.Next(0, 4);
            for (int i = 0; i < 52; i++) 
            {
                switch(color)
                {
                    case 0:
                        int spadeCard=randomNumber.Next(1, 14);
                        spade.Show(spadeCard);
                        break;
                    case 1:
                        int heartCard=randomNumber.Next(1, 14);
                        heart.Show(heartCard);
                        break;
                    case 2:
                        int diamondCard=randomNumber.Next(1, 14);
                        diamond.Show(diamondCard);
                        break;
                    case 3:
                        int clubCard=randomNumber.Next(1, 14);
                        club.Show(clubCard);
                        break;
                }
                emptyPoker[i]= Spade.result+Heart.result+Diamond.result+Club.result;
                for (int j=0;j<i;j++)
                {
                    while(emptyPoker[j]== emptyPoker[i])
                    {
                        j = 0;
                        Spade.result = "";
                        Heart.result = "";
                        Diamond.result = "";
                        Club.result = "";
                        color = randomColor.Next(0, 4);
                        switch (color)
                        {
                            case 0:
                                int spadeCard = randomNumber.Next(1, 14);
                                spade.Show(spadeCard);
                                break;
                            case 1:
                                int heartCard = randomNumber.Next(1, 14);
                                heart.Show(heartCard);
                                break;
                            case 2:
                                int diamondCard = randomNumber.Next(1, 14);
                                diamond.Show(diamondCard);
                                break;
                            case 3:
                                int clubCard = randomNumber.Next(1, 14);
                                club.Show(clubCard);
                                break;
                        }
                        emptyPoker[i] = Spade.result + Heart.result + Diamond.result + Club.result;
                        count++;
                    }
                }
            }
        }
        public void Correspond(string x)
        {
            correspondPoint = 0;
            if (Spade.spadeDict.ContainsKey(x))
            {
                correspondPoint += Spade.spadeDict[x];
            }
            else { correspondPoint += 0; }
            if (Heart.heartDict.ContainsKey(x))
            {
                correspondPoint += Heart.heartDict[x];
            }
            else { correspondPoint += 0; }
            if (Diamond.diamondDict.ContainsKey(x))
            {
                correspondPoint += Diamond.diamondDict[x];
            }
            else { correspondPoint += 0; }
            if (Club.clubDict.ContainsKey(x))
            {
                correspondPoint += Club.clubDict[x];
            }
            else { correspondPoint += 0; }
        }
        public void PlayerAdd()
        {
            Remaing();
            string card = emptyPoker[num];
            Correspond(emptyPoker[num]);
            playerNow.Add(correspondPoint.ToString());
            PlayerCard.Text += card;
            PlayerPoint.Text = (int.Parse(PlayerPoint.Text)+ correspondPoint).ToString();
            num++;
            ResetCard();
        }
        public void DealerAdd()
        {
            Remaing();
            string card = emptyPoker[num];
            Correspond(emptyPoker[num]);
            DealerNow.Add(correspondPoint.ToString());
            DealerCard.Text += card;
            DealerPoint.Text = (int.Parse(DealerPoint.Text) + correspondPoint).ToString();
            num++;
            ResetCard();
        }
        public void Again()
        {
            PlayerCard.Text = "玩家卡牌";
            PlayerPoint.Text = "0";
            DealerCard.Text = "莊家卡牌";
            DealerPoint.Text = "0";
            PlayerAddCard.Enabled = false;
            DealerAddCard.Enabled = false;
            Pass.Enabled = false;
            CheckWinner.Enabled = false;
            Deal.Enabled = true;
        }
        public void DealFunction()
        {
            playerNow = new List<string>();
            DealerNow = new List<string>();
            PlayerAdd();
            PlayerAdd();
            DealerAdd();
            DealerAdd();
            if (Rule.DealNotOver18(int.Parse(DealerPoint.Text)) == false)
            {
                CheckWinner.Enabled = true;
            }
            PlayerAddCard.Enabled = true;
            Pass.Enabled = true;
            Deal.Enabled = false;

        }
        public void ResetCard()
        {
            if(num==41)
            {
                emptyPoker = new string[52];
                num = 0;
                ChooseCard();
                RemaingCard.Text = "52";
            }
        }
        public void Remaing()
        {
            int minusCard = 1;
            RemaingCard.Text=(int.Parse(RemaingCard.Text)- minusCard ).ToString();
        }
        public void SomeOneChickenDinner(List<string> now)
        {
            if(Rule.ChickenDinner(now)==true)
            {
                MessageBox.Show("Winner Winner Chicken Dinner!");
                now.Clear();
                Again();
            }
            now.Clear();
        }
        public void DealerAutoAddCard(int point)
        {
            if (point < 18)
            {
                DealerAdd();
            }
            Rule.Winner(int.Parse(PlayerPoint.Text), int.Parse(DealerPoint.Text));
        }
        private void PlayerAddCard_Click(object sender, EventArgs e)
        {
            PlayerAdd();
            if (Rule.Over(int.Parse(PlayerPoint.Text)) == true)
            {
                MessageBox.Show("You lose!");
                Again();
            }

        }

        private void DealerAddCard_Click(object sender, EventArgs e)
        {
            DealerAdd();
            if (Rule.Over(int.Parse(DealerPoint.Text)) == true)
            {
                MessageBox.Show("Dealer lose!");
                Again();
            }
            if (Rule.DealNotOver18(int.Parse(DealerPoint.Text)) == false)
            {
                CheckWinner.Enabled = true;
            }
        }

        private void Pass_Click(object sender, EventArgs e)
        {
            SomeOneChickenDinner(DealerNow);
            DealerAutoAddCard(int.Parse(DealerPoint.Text));
            Again();
            /*DealerAddCard.Enabled = true;
            Pass.Enabled = false;
            PlayerAddCard.Enabled = false;*/
        }

        private void Deal_Click(object sender, EventArgs e)
        {
            DealFunction();
            SomeOneChickenDinner(playerNow);
        }

        private void CheckWinner_Click(object sender, EventArgs e)
        {
            Rule.Winner(int.Parse(PlayerPoint.Text), int.Parse(DealerPoint.Text));
            Again();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            ChooseCard();
            DealFunction();
            PlayerAddCard.Enabled = true;
            Pass.Enabled = true;
            Deal.Enabled = false;
            Start.Enabled = false;
        }
    }
}
