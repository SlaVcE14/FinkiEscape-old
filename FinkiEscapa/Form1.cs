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
    public partial class MainScene : Form
    {

        public MainMenuScene mainMenu;
        public HowToPlayScene howToPlay;
        public CreditsScene credits;

        public MainScene()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            mainMenu = new MainMenuScene(this);
            howToPlay = new HowToPlayScene(this);
            credits = new CreditsScene(this);


            Controls.Add(mainMenu);
            Controls.Add(howToPlay);
            Controls.Add(credits);



        }

        private void MainScene_Load(object sender, EventArgs e)
        {

        }
    }
}
