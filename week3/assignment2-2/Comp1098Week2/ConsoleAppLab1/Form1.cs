using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleAppLab1
{
    public partial class Form1 : Form
    {
        public Form1(int citySelection)
        {
            InitializeComponent();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            if (citySelection == 1)
            {
                pictureBox1.Visible = true;
            }
            else if (citySelection == 2)
            {
                pictureBox2.Visible = true;
            }
            else if (citySelection == 3)
            {
                pictureBox3.Visible = true;
            }
            
        }
    }
}
