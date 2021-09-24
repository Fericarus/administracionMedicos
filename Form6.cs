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
    public partial class Form6 : Form
    {
        // Instancia de la clase Validaciones
        Validaciones validacion = new Validaciones();

        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.validarNumeros(e);
        }
    }
}
