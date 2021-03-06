﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int gold = 500;
        int food = 0;
        const int GOLD_MINE = 300;
        const int FOOD = 400;

        public Form1()
        {
            InitializeComponent();
            
        }
        //This is all of the code for the first open spot and the choices
        //when one of the open spots are clicked, the users two options, gold or food, will then appear. Both have costs that will be deducted from their
        //starting gold amount, 500.
        private void openSpot1_Click(object sender, EventArgs e)
        {
            if(gold <= 300)
            {
                goldMineBtn.Visible = true;
            }
            else if(gold <= 400)
            {
                foodBtn.Visible = true;
            }
            else
            {
                errorTxtBox.Visible = true;
            }
            
                
        }
        //if the gold mine buton is chosen, it will make the gold mine button that accumulates appear and the others not visible
        private void goldMineBtn_Click(object sender, EventArgs e)
        {
            goldMineChoice1Btn.Visible = true;
            foodChoice1Btn.Visible = false;
            goldMineBtn.Visible = false;
            foodBtn.Visible = false;
            openSpot1btn.Visible = false;
            gold = gold - GOLD_MINE;
            goldTxtBox.Text = gold + " gold";

        }
        //if the food button is chosen, it will make the food button that accumulates appear and the others not visible
        private void foodBtn_Click(object sender, EventArgs e)
        {
            goldMineChoice1Btn.Visible = false;
            foodChoice1Btn.Visible = true;
            goldMineBtn.Visible = false;
            foodBtn.Visible = false;
            openSpot1btn.Visible = false;
            gold = gold - FOOD;
            goldTxtBox.Text = gold + " gold";

        }
        //this timer is set so over time it will accumulate a certain amount of gold. Once the gold mine button is clicked it will add the accumulated gold
        //to the total amount
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            gold = gold + 1;
        }
        //the button is clicked and the accumulated gold is added to the total gold amount
        private void goldMineChoice1Btn_Click(object sender, EventArgs e)
        {
            goldMine1Timer.Start();
            gold = gold + 1;
            goldTxtBox.Text = gold + " gold";
        }
        //just like the gold timer, this timer accumulates food over time
        private void timer2_Tick(object sender, EventArgs e)
        {
            food = food + 1;
        }
        //the accumulated food will be added to the total when cilcked
        private void foodChoice1Btn_Click(object sender, EventArgs e)
        {
            food1Timer.Start();
            food = food + 1;
            foodTxtBox.Text = food + " food";
        }
        //this is the end of the code for the first open spot and the users options


        //this is the start for the second open spot and the users choices
        private void openSpot2btn_Click(object sender, EventArgs e)
        {
            goldMineBtn.Visible = true;
            foodBtn.Visible = true;
        }

        private void goldMineChoice2Btn_Click(object sender, EventArgs e)
        {
            gold = gold + 1;
            goldTxtBox.Text = gold + " gold";

        }
    }
}
