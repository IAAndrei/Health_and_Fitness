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
    public partial class Data_UserControl : UserControl
    {
        public Data_UserControl()
        {
            InitializeComponent();
            List<Control> lb = Controls.OfType<Label>().Cast<Control>().ToList();
            foreach (var eachlb in lb)
            {
                eachlb.Parent = DataBG_PictureBox;
                eachlb.ForeColor = Color.FromArgb(255, 255, 255);
            }
            DataPanel.Parent = DataBG_PictureBox;
            chart1.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
        }
    }
}
