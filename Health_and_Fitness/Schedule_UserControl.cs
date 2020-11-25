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
    public partial class Schedule_UserControl : UserControl
    {
        public Schedule_UserControl()
        {
            InitializeComponent();
            List<Control> lb = Controls.OfType<Label>().Cast<Control>().ToList();
            foreach (var eachlb in lb)
            {
                eachlb.Parent = ScheduleBG_PictureBox;
                eachlb.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Schedule_UserControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
