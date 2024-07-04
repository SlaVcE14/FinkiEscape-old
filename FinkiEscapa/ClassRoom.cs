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
    public partial class ClassRoom : UserControl
    {

        GameForm main;
        int startMsgId = 0;

        public ClassRoom(GameForm main)
        {
            InitializeComponent();
            this.main = main;

            DoubleBuffered = true;

            //panel1.Parent = pictureBox1;
            dialogPanel.BackColor = Color.FromArgb(100, Color.Black);

        }

        

        private void goToBreakerBox()
        {
            Visible = false;
            main.breakerBox.Visible = true;
        }

        private void goToPCDisplay()
        {
            Visible = false;
            main.pcDisplay.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goToBreakerBox();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            goToPCDisplay();
        }


        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {


            //panel1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //nextDialog();
        }


        private void nextDialog()
        {
            if (startMsgId < StringData.startGameDialogs.Count)
            {
                dialogText.Text = StringData.startGameDialogs[startMsgId];
                startMsgId++;
                return;
            }

            dialogPanel.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nextDialog();
            dialogPanel.Visible = true;
            timer1.Enabled = false;
        }

        private void panel1_MouseClick_1(object sender, MouseEventArgs e)
        {
            nextDialog();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            goToBreakerBox();
        }

        public void keyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (dialogPanel.Visible)
                {
                    nextDialog();
                }
            }
        }
    }
}
