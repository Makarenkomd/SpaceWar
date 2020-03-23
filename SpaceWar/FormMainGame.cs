using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpaceWar
{
    public partial class FormMainGame : Form
    {
        public FormMainGame()
        {
            InitializeComponent();
        }

        private void timerEnemyShip_Tick(object sender, EventArgs e)
        {
            pictureBoxEnemyShip.Top += 1;
        }

        private void FormMainGame_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void FormMainGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                pictureBoxMyShip.Left -= 10;
            if (e.KeyCode == Keys.Right)
                pictureBoxMyShip.Left += 10;
        }
    }
}
