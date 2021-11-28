using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity11_Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dice a;
        Dice b;
        int rollCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random sideGenerator = new Random();

            int diceFaces = sideGenerator.Next(4, 20);

            a = new Dice(diceFaces);
            dice1.Text = (a.GetSetFaceUp).ToString();
            dice1.Visible = true;

            b = new Dice(diceFaces);
            dice2.Text = (b.GetSetFaceUp).ToString();
            dice2.Visible = true;

            diceGroupBox.Text = "Two " + diceFaces + " sided die were created";

        }

        private void rollButton_Click(object sender, EventArgs e)
        {


            //from here new code starts
            do
            {
                rollCount += 1;
                label1.Text = "You've rolled " + rollCount.ToString() + " times";

                a.RollDice();
                dice1.Text = a.GetSetFaceUp.ToString();
                dice1.Refresh();

                //avoid generating the same random number
                System.Threading.Thread.Sleep(20);

                b.RollDice();
                dice2.Text = b.GetSetFaceUp.ToString();
                dice2.Refresh();

                System.Threading.Thread.Sleep(400);
                label1.Refresh();
            } while (!(a.GetSetFaceUp == 1 && b.GetSetFaceUp == 1));
            
            label1.Text = "It took " + rollCount.ToString() + " rolls to get snake eyes";



            /*rollCount += 1;

            if (rollCount == 1)
            {
                if (dice1.Text == "1" && dice1.Text == "1")
                {
                    label1.Text = "You got snake eyes on your first try!";
                }
            }
            if (a.RollDice()==1 && b.RollDice()==1)
            {
                label1.Text = "It took " + rollCount.ToString() + " rolls to get snake eyes";
            }*/

        }
    }
}
