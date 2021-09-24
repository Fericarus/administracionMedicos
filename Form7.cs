using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2A1IDEISAC
{
    public partial class Form7 : Form
    {
        Validaciones validacion = new Validaciones();
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.validarNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.validarLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.validarNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.validarNumeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.validarNumeros(e);
        }
    }
}
