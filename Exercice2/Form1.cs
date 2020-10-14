using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
