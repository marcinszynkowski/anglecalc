using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngleCalc
{
    public partial class AngleCalc : Form
    {
        public AngleCalc()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            int hours = Int32.Parse(hour.Text);
            int minutes = Int32.Parse(mins.Text);

            if (hours > 12)
            {
                hours = hours - 12;
            }

            int hour_angle = hours * 30;
            int mins_angle = minutes * 6;

            if (minutes > hours) {
                int result = mins_angle - hour_angle;
                if (result < 0)
                {
                    result = result * (-1);
                }
                angle.Text = result.ToString();
            }
            else
            {
                int result = hour_angle - mins_angle;
                if (result < 0)
                {
                    result = result * (-1);
                }
                angle.Text = result.ToString();
            }
        }
    }
}
