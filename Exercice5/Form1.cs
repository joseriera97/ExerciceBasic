using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Exercice 5
        //Comprobamos cuales estan activos.
        private void ex5OkButton_Click(object sender, EventArgs e)
        {
            String resultado = "Choosen animals :";

            if (ex5MouseCheckBox.Checked)
            {
                resultado = resultado + " " + ex5MouseCheckBox.Text;
            }
            if (ex5CatCheckBox.Checked)
            {
                resultado = resultado + " " + ex5CatCheckBox.Text;
            }
            if (ex5DogCheckBox.Checked)
            {
                resultado = resultado + " " + ex5DogCheckBox.Text;
            }

            ex5ListAnimalesTextBox.Text = resultado;
        }
    }
}
