using MySql.Data.MySqlClient;
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
    public partial class Form2 : Form
    {
        // Creamos string de conexión
        static private string stringConecction = "server=localhost; database=dbu3isac; user=root; password=1984Orwell*; SslMode=none";

        // Creamos objeto de conexión
        MySqlConnection myConnection = new MySqlConnection(stringConecction);

        // Creamos una instanción de la clase Validaciones para este formulario
        Validaciones validacion = new Validaciones();

        public Form2()
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.validarNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.validarLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Alamacenamos en variables de tipo string el contenido de cada TextBox
            string idMedico = textBox1.Text;
            string nombreCompleto = textBox2.Text;
            string cedula = textBox3.Text;
            string especialidad = textBox4.Text;

            if (idMedico == "" || nombreCompleto == "" || cedula == "" || especialidad == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                // Query para insertar valores a la base de datos
                string query = "INSERT INTO tbmedicos(IdMedico, NombreCompleto, Cedula, Especialidad) " +
                    "VALUES ('" + idMedico + "','" + nombreCompleto + "','" + cedula + "','" + especialidad + "')";

                /* Instanciamos un objeto MySqlCommand que recibirá por parametro el query y el objeto global de conexión */
                MySqlCommand comando = new MySqlCommand(query, myConnection);

                try
                {
                    // Abrimos la conexión
                    myConnection.Open();

                    comando.ExecuteNonQuery();

                    // Mensaje de registro exitoso
                    MessageBox.Show("El registro del médico " + idMedico + " fue exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Cerramos la conexión
                    myConnection.Close();

                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error de conexión", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
