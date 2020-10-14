using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Exerici 1

        private void helloText_Click_1(object sender, EventArgs e)
        {
            const string mensaje = "Hello";
            const string confirm = "!!! Atencion !!!";
            DialogResult result = MessageBox.Show(mensaje, confirm,
                                         MessageBoxButtons.OK);
        }
    }
}
