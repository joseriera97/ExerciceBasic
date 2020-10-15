using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Conseguir los numeros pares
        private void parButton_Click(object sender, EventArgs e)
        {
            //Vaciar los items que tengamos en el ListBox
            numerosComboBox.Items.Clear();

            //load a list, t, with 10 integers
            List<int> t = Enumerable.Range(0, 10).ToList();

            //find even numbers
            var evenNumbers = t.Where(num => num % 2 == 0);

            //Poner los numeros pares
            foreach (int i in evenNumbers)
                numerosComboBox.Items.Add(i);


        }

        //Conseguir los numeros impares
        private void imparButton_Click(object sender, EventArgs e)
        {
            //Vaciar los items que tengamos en el ListBox
            numerosComboBox.Items.Clear();

            //load a list, t, with 10 integers
            List<int> t = Enumerable.Range(0, 10).ToList();

            //find odd numbers
            var oddNumbers = t.Where(num => num % 2 != 0);

            //print odd numbers
            foreach (int i in oddNumbers)
                numerosComboBox.Items.Add(i);


        }

        private void numerosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            numeroTextBox.Text = numerosComboBox.SelectedItem.ToString();
        }
    }
}
