using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Tinhptbac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, x;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
             if (a !=0)
            {
                x = -b / a;
                lblKQ.Text = "Nghiệm của phương trình là x =" + x.ToString();
            }
            else
            {
                if (b != 0)
                {
                    lblKQ.Text = "phương trình vô nghiệm";
                }
                else
                {
                    lblKQ.Text = "Phương trình đúng với mọi x";
                }
            }
        }
    }
}
