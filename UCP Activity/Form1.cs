﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCP_Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string inOneInput {
            set
            {
                InputOneOut.Text = value;
            }
        }
        public string inTwoInput
        {
            set
            {
                InputTwoOut.Text = value;
            }
        }
 
        private void panelBtn_Click(object sender, EventArgs e)
        {
            panelOne1.Show();
            panelOne1.BringToFront();

            panelTwo1.Hide();
        }

        private void panel2Btn_Click(object sender, EventArgs e)
        {
            panelTwo1.Show();
            panelTwo1.BringToFront();

            panelOne1.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelOne1_Load(object sender, EventArgs e)
        {

        }
    }
}
