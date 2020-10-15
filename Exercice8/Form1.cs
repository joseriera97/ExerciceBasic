using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Clear Items
        private void clearListButton_Click(object sender, EventArgs e)
        {
            //Vaciar los items que tengamos en el ListBox
            claseListBox.Items.Clear();
            personTextBox.Text = "";
        }

        //Una vez seleccionado un item de la lista , mostrarlo en el text.
        private void claseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            personTextBox.Text = claseListBox.SelectedItem.ToString();
        }

        private void class1Button_Click(object sender, EventArgs e)
        {
            string[] class1 = new string[3] { "Jose", "Jorge", "Javi" };

            //Vaciar los items que tengamos en el ListBox
            claseListBox.Items.Clear();
            // Hago un bucle según la grandaria del array de String para introducir item por item.
            for (int x = 0; x < class1.Length; x++)
            {
                claseListBox.Items.Add(class1[x]);
            }
        }

        private void class2Button_Click(object sender, EventArgs e)
        {
            string[] class2 = new string[3] { "Andy", "Sech", "Pepe" };

            //Vaciar los items que tengamos en el ListBox
            claseListBox.Items.Clear();
            // Hago un bucle según la grandaria del array de String para introducir item por item.
            for (int x = 0; x < class2.Length; x++)
            {
                claseListBox.Items.Add(class2[x]);
            }
        }
    }
}
