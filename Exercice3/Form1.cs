using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            operador1TextBox.Text = "0";
            operador2TextBox.Text = "0";
            resultTextBox.Text = "0";
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(operador1TextBox.Text);
            int number2 = Int32.Parse(operador2TextBox.Text);
            int resultado = number1 + number2;
            resultTextBox.Text = resultado + " ";
        }
    }
}
