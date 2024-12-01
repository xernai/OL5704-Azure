using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola estoy en btnSubmit_Click EventHandler", "Info");

            // ConexionDb(5);
        }

        private void Saludar(object sender, EventArgs e)
        {
            MessageBox.Show("Hola estoy en Saludar", "Info");

            // ConexionDb(5);
        }
        private void ConexionDb(int value)
        {
            throw new NotImplementedException();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
