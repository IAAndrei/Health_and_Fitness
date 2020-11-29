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
    public partial class Home_UserControl : UserControl
    {
        public Home_UserControl()
        {
            InitializeComponent();
            List<Control> lb = Controls.OfType<Label>().Cast<Control>().ToList();
            foreach (var eachlb in lb)
            {
                eachlb.Parent = HomeBG_PictureBox;
                eachlb.ForeColor = Color.FromArgb(255, 255, 255);
            }
            HeaderPanel.Parent = HomeBG_PictureBox;
            icon1.Parent = HomeBG_PictureBox;
            icon2.Parent = HomeBG_PictureBox;
            icon3.Parent = HomeBG_PictureBox;
        }
        
    }
}
