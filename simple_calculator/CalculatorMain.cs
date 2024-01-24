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
            textBox.KeyDown += TextBox_KeyDown;
        }
        
        private void CalculatorMain_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ProceedtoNewForm();
            }
        }

        private void btnShowtxtbox_Click(object sender, EventArgs e)
        {
            
            textBox.Size = new Size(281, 44);
            textBox.Location = new Point(30, 96);
            textBox.Font = new Font("Segoe UI",24);
            textBox.BackColor = Color.FromArgb(50, 53, 56);
            textBox.ForeColor = Color.White;
            textBox.UseSystemPasswordChar = true;
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
                MessageBox.Show("Error, Enter the right code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(textBox);
            textBox.Text = "";
            label1.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
