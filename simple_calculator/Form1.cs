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
    public partial class Form1 : Form
    {
        private string currInput = "";
        private double result = 0;
        private string operation = "";
        

        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnDigit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currInput += button.Text;
            UpdateDisplay();
            txtBox.ForeColor = Color.White;
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
           
            if (!string.IsNullOrEmpty(currInput))
            {
                double inputNumber = double.Parse(currInput);

                if (result == 0)
                {
                    result = inputNumber;
                    operation = button.Text;
                }
                else
                {
                    Calculate();
                    operation = button.Text;
                }

                currInput = "";
                UpdateDisplay();
                txtBox.ForeColor = Color.White;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currInput))
            {
                double inputNumber = double.Parse(currInput);
                Calculate();
                currInput = result.ToString();
                UpdateDisplay();
                result = 0;
                operation = "";
                _updateResultColor();
            }
        }

        private void Calculate()
        {
            switch (operation)
            {
                case "+":
                    result += double.Parse(currInput);
                    break;
                case "-":
                    result -= double.Parse(currInput);
                    break;
                case "x":
                    result *= double.Parse(currInput);
                    break;
                case "/":
                    if (double.Parse(currInput) != 0)
                    {
                        result /= double.Parse(currInput);
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = 0;
                    }
                    break;
                case "%":
                    result = result * (double.Parse(currInput) / 100);
                    break;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currInput = "";
            result = 0;
            operation = "";
            UpdateDisplay();
            Console.ResetColor();
        }
        private void UpdateDisplay()
        {
            txtBox.Text = currInput;
            
        }
        private void _updateResultColor()
        {
            try
            {
                if(result < 0)
                {
                    txtBox.ForeColor = Color.Red;
                    
                    
                }
            }
            catch
            {
                txtBox.ForeColor = Color.White;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEquals_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            _updateResultColor();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
