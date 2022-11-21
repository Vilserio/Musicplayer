using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yt_mwldr
{
    public partial class Form1 : Form
    {
        bool mousedown;

        public Form1()
        {
            InitializeComponent();
        }

        private void fileLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void controlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void controlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 392;
                int mousey = MousePosition.Y - 17;
                //int mousex = MousePosition.X - 0;
                //int mousey = MousePosition.Y - 0;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void controlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }
    }
}
