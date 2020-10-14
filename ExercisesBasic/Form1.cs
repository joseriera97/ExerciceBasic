using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisesBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Exerici 1
        private void helloText_Click(object sender, EventArgs e)
        {

            const string mensaje = "Hello";
            const string confirm = "!!! Atencion !!!";
            DialogResult result = MessageBox.Show(mensaje, confirm,
                                         MessageBoxButtons.OK);
        }

        //Exercici 2
        private void exercice2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Boolean estado = exercice2CheckBox.ThreeState;
            Boolean estado = exercice2CheckBox.Checked;//Comprobar si esta check

            //if (!exercice2CheckBox.ThreeState)
            if (!estado)

             {
               // exercice2CheckBox.ThreeState = true;
                exercice2CheckBox.CheckAlign = ContentAlignment.MiddleRight;

                MessageBox.Show("Checkbox unchecked");

            }
            else /*if (exercice2CheckBox.ThreeState)*/
            {
                //exercice2CheckBox.ThreeState = false;
                exercice2CheckBox.CheckAlign = ContentAlignment.MiddleLeft;
                MessageBox.Show("Checkbox checked");
            }
        }

        //Exercici 3

            //Reset
        private void resetButton_Click(object sender, EventArgs e)
        {
            operador1TextBox.Text = "0";
            operador2TextBox.Text = "0";
            resultTextBox.Text = "0";

        }
            //Sumar
        private void sumButton_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(operador1TextBox.Text);
            int number2 = Int32.Parse(operador2TextBox.Text);
            int resultado = number1 + number2;
            resultTextBox.Text = resultado + " ";

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
