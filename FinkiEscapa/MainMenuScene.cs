using System;
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
    public partial class MainMenuScene : UserControl
    {

        MainScene main;

        public MainMenuScene(MainScene main)
        {
            InitializeComponent();
            this.main = main;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            main.howToPlay.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visible = false;
            main.credits.Visible = true;
        }
    }
}
