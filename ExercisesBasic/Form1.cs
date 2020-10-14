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
    }
}
