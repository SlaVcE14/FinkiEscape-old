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
    public partial class CreditsScene : UserControl
    {

        MainScene main;

        public CreditsScene(MainScene main)
        {
            InitializeComponent();
            this.main = main;
            Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            Visible = false;
            main.mainMenu.Visible = true;
        }
    }
}
