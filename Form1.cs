using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateaveregebutton_Click(object sender, EventArgs e)
        {
            try
            {
                double test1;
                double test2;
                double test3;
                double average;

                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(Test2textBox.Text);
                test3 = double.Parse(Test3textBox.Text);

                average = (test1 + test2 + test3) / 3.0;

                average_label.Text = average.ToString("n1");


            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = " ";
            Test2textBox.Text = " ";
            Test3textBox.Text = " ";
            average_label.Text = " ";

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
