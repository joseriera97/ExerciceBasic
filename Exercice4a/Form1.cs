using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice4a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Exercici 4
        //Poner la operacion en suma
        private void ex4SumarButton_Click(object sender, EventArgs e)
        {
            ex4OperacionTextBox.Text = "+";
        }
        //Poner la operacion en resta

        private void ex4RestarButton_Click(object sender, EventArgs e)
        {
            ex4OperacionTextBox.Text = "-";
        }
        //Resetear valores

        private void ex4ResetButton_Click(object sender, EventArgs e)
        {
            ex4Operant1TextBox.Text = "0";
            ex4Operant2TextBox.Text = "0";
            ex4ResultatTextBox.Text = "0";
        }
        //Realizar la operacion

        private void ex4CalcularButton_Click(object sender, EventArgs e)
        {
            string operacion = ex4OperacionTextBox.Text;
            string suma = "+";
            string resta = "-";

            if (operacion == suma)
            {
                int number1 = Int32.Parse(ex4Operant1TextBox.Text);
                int number2 = Int32.Parse(ex4Operant2TextBox.Text);
                int resultado = number1 + number2;
                ex4ResultatTextBox.Text = resultado + " ";
            }
            else if (operacion == resta)
            {
                int number1 = Int32.Parse(ex4Operant1TextBox.Text);
                int number2 = Int32.Parse(ex4Operant2TextBox.Text);
                int resultado = number1 - number2;
                ex4ResultatTextBox.Text = resultado + " ";
            }
            else
            {
                const string mensaje = "Seleccione un tipo de Operacion";
                const string confirm = "!!! Atencion !!!";
                DialogResult result = MessageBox.Show(mensaje, confirm,
                                             MessageBoxButtons.OK);
            }
        }
    }
}
