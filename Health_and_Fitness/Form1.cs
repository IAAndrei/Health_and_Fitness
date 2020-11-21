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
        readonly Timer t1 = new Timer(); // a timer
        readonly Timer t2 = new Timer(); // second timer


        public Main_Form()
        {
            InitializeComponent();
        }




        // Move window with mouse drag functions

        public void StartMoving()
        {
            moving = true;
            Title_bar.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }

        public void IsMoving()
        {
            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);
        }

        public void EndMoving()
        {
            moving = false;
            Title_bar.Capture = false;
        }


        // form drag starts here
        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            StartMoving();
        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            IsMoving();
        }

        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            EndMoving();
        }

        //exit button

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            t2.Interval = 10;
            t2.Tick += new EventHandler(FadeOut);
            t2.Start();

            if (Opacity <= 0)
            {
                this.Close();
            }
        }

        //form minimize anim + min button

        private void Minimize_BTN_Click(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Minimized;
        }
        private void Main_Form_Activated(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
        }


        // Mouse window drag from Title & Icon
        private void Title_Label_MouseDown(object sender, MouseEventArgs e)
        {
            StartMoving();
        }

        private void Title_Label_MouseMove(object sender, MouseEventArgs e)
        {
            IsMoving();
        }

        private void Title_Label_MouseUp(object sender, MouseEventArgs e)
        {
            EndMoving();
        }

        private void Icon_PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            StartMoving();
        }

        private void Icon_PicBox_MouseMove(object sender, MouseEventArgs e)
        {
            IsMoving();
        }

        private void Icon_PicBox_MouseUp(object sender, MouseEventArgs e)
        {
            EndMoving();
        }

        // On load, fade in the form. On exit, fade out the form.

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            t1.Interval = 10;
            t1.Tick += new EventHandler(FadeIn);
            t1.Start();
        }

        private void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                t1.Stop();
            } else
            {
                Opacity += 0.05;
            }
        }

        private void FadeOut(object sender, EventArgs e)
        {
            if(Opacity > 0)
            {
                Opacity -= 0.05;
            } else
            {
                this.Close();
            }
        }
    }
}