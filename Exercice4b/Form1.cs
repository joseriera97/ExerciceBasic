using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice4b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Exercice 4b
        //Reset
        private void button2_Click(object sender, EventArgs e)
        {
            ex4bOperant1TextBox.Text = "0";
            ex4bOperant2TextBox.Text = "0";
            ex4bResultatTextBox.Text = "0";
        }

        private void ex4bOperadorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //paso a string el item seleccionado
            string operacion = ex4bOperadorListBox.SelectedItem.ToString();
            //Lo guardo en su contenedor.
            ex4bOperacionTextBox.Text = operacion;
        }

        private void ex4bCalcularButton_Click(object sender, EventArgs e)
        {
            string operacion = ex4bOperacionTextBox.Text;
            string suma = "+";
            string resta = "-";

            if (operacion == suma)
            {
                int number1 = Int32.Parse(ex4bOperant1TextBox.Text);
                int number2 = Int32.Parse(ex4bOperant2TextBox.Text);
                int resultado = number1 + number2;
                ex4bResultatTextBox.Text = resultado + " ";
            }
            else if (operacion == resta)
            {
                int number1 = Int32.Parse(ex4bOperant1TextBox.Text);
                int number2 = Int32.Parse(ex4bOperant2TextBox.Text);
                int resultado = number1 - number2;
                ex4bResultatTextBox.Text = resultado + " ";
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
