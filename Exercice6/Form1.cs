using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ex6Button_Click(object sender, EventArgs e)
        {
            bool radioButtonMarcado = false;
            string active = "";

            //Recorro el grupo su contenido Radio Button
            foreach (RadioButton rdo in coloresGroupBox.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    radioButtonMarcado = true;
                    active = rdo.Text;
                    break;
                }
            }
            if (radioButtonMarcado)
            {
                // Si hay uno seleccionado.
                ex5ListAnimalesTextBox.Text = "Choosen Colour: " + active;

            }
            else
            {//No hay ningún radio button seleccionado
                ex5ListAnimalesTextBox.Text = "Choosen Colour: ";
            }
        }
    }
}
