using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_and_Fitness
{
    public partial class Main_Form : Form
    {

        bool moving; //is the form moving
        Point offset; //form offset position
        Point original; //form original position


        public Main_Form()
        {
            InitializeComponent();
        }


        // form drag starts here
        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            title_bar.Capture = true;
            offset = MousePosition;
            original = this.Location;

        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);

        }

        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            title_bar.Capture = false;

        }

        //exit button

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //form minimize anim + min button

        private void Minimize_BTN_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Minimized;
        }
        private void Main_Form_Activated(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
