using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2A1IDEISAC
{
    // Hacemos la clase pública para poder acceder a ella desde cualquier formulario
    public class Validaciones
    {
        /* Método que invocaré si deseo validar letras. Le pasamos por parametro un objeto del tipo "KeyPressEventArgs"
         * agregando el "System.Windows.Forms" correspondiente en las librerías
         */
        public void validarLetras(KeyPressEventArgs e) 
        {
            // Permitimos que el usuario presione teclas de letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            // Permitimos que el usuario presione la tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            // Permitimos que el usuario presiones teclas de borrar, tabulador y otras del tipo comando
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            // En caso contrario se mostrará un mensaje al usuario indicándole que solo se permiten letras en el formulario
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método que invocaré si deseo validar números
        public void validarNumeros(KeyPressEventArgs e)
        {
            // Permitimos que el usuario ingrese números
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            // Permitimos que el usuario pueda presionar las teclas de comando
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            // En todos los casos contrarios a los anteriores, se le mostrará un mensaje al usuario que solo se permiten números
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
