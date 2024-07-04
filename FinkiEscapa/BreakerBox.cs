﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinkiEscapa
{
    public partial class BreakerBox : UserControl
    {

        GameForm main;

        public BreakerBox(GameForm main)
        {
            InitializeComponent();
            this.main = main;
            Visible = false;


        }

        private void goToClassRoom()
        {
            Visible = false;
            main.classRoom.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goToClassRoom();
        }

        public void keyDown(KeyEventArgs e)
        {

        }
    }
}