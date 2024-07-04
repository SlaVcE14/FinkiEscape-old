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
    public partial class PCDisplay : UserControl
    {

        GameForm main;

        public PCDisplay(GameForm main)
        {
            InitializeComponent();

            DoubleBuffered = true;

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
