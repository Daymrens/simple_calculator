using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator
{
    public partial class CalculatorMain : Form
    {
        private TextBox textBox = new TextBox();
        public CalculatorMain()
        {
            InitializeComponent();
        }
        
        private void CalculatorMain_Load(object sender, EventArgs e)
        {

        }

        private void btnShowtxtbox_Click(object sender, EventArgs e)
        {
            
            textBox.Size = new Size(281, 44);
            textBox.Location = new Point(30, 96);
            textBox.Font = new Font("Segoe UI",24);
            this.Controls.Add(textBox);
            label1.Visible = false;
           

        }

        private void _ProceedtoNewForm()
        {
            if(textBox.Text == "calculator")
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("hHy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(textBox);
            textBox.Text = "";
            label1.Visible = true;
        }


       
    }
}
