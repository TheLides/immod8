﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();
        public List<String> predictions = new List<string>() {
            "It is certain",
            "It is decidedly so",
            "Without a doubt",
            "Yes — definitely",
            "You may rely on it",
            "As I see it, yes",
            "Most likely",
            "Outlook good",
            "Signs point to yes",
            "Yes",
            "Reply hazy, try again",
            "Ask again later",
            "Better not tell you now",
            "Cannot predict now ",
            "Concentrate and ask again",
            "Don’t count on it",
            "My reply is no",
            "My sources say no",
            "Outlook not so good",
            "Very doubtful"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rnd.NextDouble() < 0.5d)
            {
                labelAns.Text = "Yes";
            }
            else
            {
                labelAns.Text = "No";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double current = rnd.NextDouble();
            double ourProb = (double) 1 / predictions.Count;
            foreach(var ans in predictions)
            {
                current -= ourProb;
                if(current <= 0)
                {
                    labelAns.Text = ans;
                    break;
                }
            }
            
        }
    }
}
