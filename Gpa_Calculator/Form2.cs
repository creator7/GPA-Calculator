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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Enabled = true;
                comboBox7.Enabled = true;
                comboBox5.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
                comboBox7.Enabled = false;
                comboBox5.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox4.Enabled = true;
                comboBox8.Enabled = true;
                comboBox6.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
                comboBox8.Enabled = false;
                comboBox6.Enabled = false;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                textBox7.Enabled = true;
                comboBox9.Enabled = true;
                comboBox11.Enabled = true;
            }
            else
            {
                textBox7.Enabled = false;
                comboBox9.Enabled = false;
                comboBox11.Enabled = false;
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                textBox6.Enabled = true;
                comboBox10.Enabled = true;
                comboBox12.Enabled = true;
            }
            else
            {
                textBox6.Enabled = false;
                comboBox10.Enabled = false;
                comboBox12.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CalculateGpa() == 0)
            {
                MessageBox.Show("\t      ERORR!!\n\nPlease Enter Values in Empty Boxes.");
            }
            else
            {
                textBox5.Enabled = true;
                textBox5.Text = System.Convert.ToString(CalculateGpa());
            }
        }
        public double CalculateGpa()
        {
            int Cr_Hr_count = 0;
            double grade_count = 0;
            double Grade;
            string Cr_Hr;
            double Gpa = 0;
            int count = 0;
            if (checkBox1.Checked)
            {
                if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                {
                    return 0;
                }
                Cr_Hr = this.comboBox2.SelectedItem.ToString();
                Grade = grade_converter(comboBox1.SelectedItem.ToString());
                grade_count = grade_count + (System.Convert.ToInt32(Cr_Hr) * Grade);
                Cr_Hr_count = Cr_Hr_count + System.Convert.ToInt32(Cr_Hr);
                count++;
            }
            if (checkBox2.Checked)
            {
                if (comboBox3.SelectedItem == null || comboBox4.SelectedItem == null)
                {
                    return 0;
                }
                Cr_Hr = this.comboBox3.SelectedItem.ToString();
                Grade = grade_converter(comboBox4.SelectedItem.ToString());
                grade_count = grade_count + (System.Convert.ToInt32(Cr_Hr) * Grade);
                Cr_Hr_count = Cr_Hr_count + System.Convert.ToInt32(Cr_Hr);
                count++;
            }
            if (checkBox3.Checked)
            {
                if (comboBox7.SelectedItem == null || comboBox5.SelectedItem == null)
                {
                    return 0;
                }
                Cr_Hr = this.comboBox7.SelectedItem.ToString();
                Grade = grade_converter(comboBox5.SelectedItem.ToString());
                grade_count = grade_count + (System.Convert.ToInt32(Cr_Hr) * Grade);
                Cr_Hr_count = Cr_Hr_count + System.Convert.ToInt32(Cr_Hr);
                count++;
            }
            if (checkBox4.Checked)
            {
                if (comboBox8.SelectedItem == null || comboBox6.SelectedItem == null)
                {
                    return 0;
                }
                Cr_Hr = this.comboBox8.SelectedItem.ToString();
                Grade = grade_converter(comboBox6.SelectedItem.ToString());
                grade_count = grade_count + (System.Convert.ToInt32(Cr_Hr) * Grade);
                Cr_Hr_count = Cr_Hr_count + System.Convert.ToInt32(Cr_Hr);
                count++;
            }
            if (checkBox5.Checked)
            {
                if (comboBox9.SelectedItem == null || comboBox11.SelectedItem == null)
                {
                    return 0;
                }
                Cr_Hr = this.comboBox9.SelectedItem.ToString();
                Grade = grade_converter(comboBox11.SelectedItem.ToString());
                grade_count = grade_count + (System.Convert.ToInt32(Cr_Hr) * Grade);
                Cr_Hr_count = Cr_Hr_count + System.Convert.ToInt32(Cr_Hr);
                count++;
            }
            if (checkBox6.Checked)
            {
                if (comboBox10.SelectedItem == null || comboBox12.SelectedItem == null)
                {
                    return 0;
                }
                Cr_Hr = this.comboBox10.SelectedItem.ToString();
                Grade = grade_converter(comboBox12.SelectedItem.ToString());
                grade_count = grade_count + (System.Convert.ToInt32(Cr_Hr) * Grade);
                Cr_Hr_count = Cr_Hr_count + System.Convert.ToInt32(Cr_Hr);
                count++;
            }
            if (count != 0)
            {
                Gpa = grade_count / Cr_Hr_count;
                Gpa = Math.Round(Gpa, 2);
                return Gpa;
            }
            else
            {
                return 0;
            }

        }
        private double grade_converter(string s)
        {
            if (s == "A")
            {
                return 4.00;
            }
            else if (s == "A-")
            {
                return 3.75;
            }
            else if (s == "B+")
            {
                return 3.5;
            }
            else if (s == "B")
            {
                return 3.00;
            }
            else if (s == "C+")
            {
                return 2.5;
            }
            else if (s == "C")
            {
                return 2.00;
            }
            else if (s == "D+")
            {
                return 1.5;
            }
            else if (s == "D")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple GPA Calculator.\t\n\n\bVersion:        1.023\t\n\bCompany:    A&R Studio\t\n\n          Copyright ©  2014\t");
        }

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\tCheck the EmptyBox of Courses\t\n\tYou Want To Enter.\t\n\n\t'Clear All' \tButton Clears All fields\t\n\t'Clear Selected' Clears the data\n\tfrom fields where CheckBox is Checked\t\n\n\tFill All spaces properly\t\n\tHit Calculate button To Get the Results :)\t");
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t               EMAIL\n\n         \b\b\b\b\b\b\b\b\b\b\b\b\b  abdullabintariq@gmail.com  \b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            int count1 = 0;
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked)
            {
                if (checkBox1.Checked)
                {
                    count1++;
                    if (textBox1.Text!= "" || comboBox1.SelectedItem != null || comboBox2.SelectedItem != null)
                    {
                        comboBox1.SelectedIndex = -1;
                        comboBox2.SelectedIndex = -1;
                        textBox1.Text = "";
                        count++;
                    }
                }
                if (checkBox2.Checked)
                {
                    count1++;
                    if (textBox2.Text != "" || comboBox3.SelectedItem != null || comboBox4.SelectedItem != null)
                    {
                        comboBox3.SelectedIndex = -1;
                        comboBox4.SelectedIndex = -1;
                        textBox2.Text = "";
                        count++;
                    }
                }
                if (checkBox3.Checked)
                {
                    count1++;
                    if (textBox3.Text != "" || comboBox5.SelectedItem != null || comboBox7.SelectedItem != null)
                    {
                        comboBox5.SelectedIndex = -1;
                        comboBox7.SelectedIndex = -1;
                        textBox3.Text = "";
                        count++;
                    }
                }
                if (checkBox4.Checked)
                {
                    count1++;
                    if (textBox4.Text != "" || comboBox6.SelectedItem != null || comboBox8.SelectedItem != null)
                    {
                        comboBox6.SelectedIndex = -1;
                        comboBox8.SelectedIndex = -1;
                        textBox4.Text = "";
                        count++;
                    }
                }
                if (checkBox5.Checked)
                {
                    count1++;
                    if (textBox7.Text != "" || comboBox9.SelectedItem != null || comboBox11.SelectedItem != null)
                    {
                        comboBox9.SelectedIndex = -1;
                        comboBox11.SelectedIndex = -1;
                        textBox7.Text = "";
                        count++;
                    }
                }
                if (checkBox6.Checked)
                {
                    count1++;
                    if (textBox6.Text != "" || comboBox10.SelectedItem != null || comboBox12.SelectedItem != null)
                    {
                        comboBox10.SelectedIndex = -1;
                        comboBox12.SelectedIndex = -1;
                        textBox6.Text = "";
                        count++;
                    }
                }
            }
            if (count == 0 && count1 == 0)
            {
                MessageBox.Show("Nothing Selected Yet!!");
            }
            else if(count==0 && count1>0)
            {
                MessageBox.Show("Nothing Entered In selected Fields!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && comboBox1.SelectedItem == null && comboBox2.SelectedItem == null &&
                textBox2.Text == "" && comboBox3.SelectedItem == null && comboBox4.SelectedItem == null &&
                textBox3.Text == "" && comboBox5.SelectedItem == null && comboBox7.SelectedItem == null &&
                textBox4.Text == "" && comboBox6.SelectedItem == null && comboBox8.SelectedItem == null &&
                textBox7.Text == "" && comboBox9.SelectedItem == null && comboBox11.SelectedItem == null &&
                textBox6.Text == "" && comboBox10.SelectedItem == null && comboBox12.SelectedItem == null
            )
            {
                MessageBox.Show("Nothing To Clear!!");
            }
            else
            {
               comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;
                comboBox7.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;
                comboBox11.SelectedIndex = -1;
                comboBox12.SelectedIndex = -1;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                MessageBox.Show("Already Checked!!");
            }
            else
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked)
            {
                MessageBox.Show("Already UnChecked!!");
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
        }
    }
}
