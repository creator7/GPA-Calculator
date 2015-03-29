using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gpa_Calculator
{
    public partial class Form1 : Form
    {
        private Form2 f2;
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled=false;
            f2.ShowDialog();
            this.Enabled=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog= MessageBox.Show("Want to Exit??","Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple GPA Calculator.\t\n\n\bVersion:        1.023\t\n\bCompany:    A&R Studio\t\n\n          Copyright ©  2014\t");
        }

    }
}
