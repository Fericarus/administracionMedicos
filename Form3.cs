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
    public partial class Form3 : Form
    {
        // Creamos string de conexión
        static private string stringConecction = "server=localhost; database=dbu3isac; user=root; password=1984Orwell*; SslMode=none";

        // Creamos objeto de conexión
        MySqlConnection myConnection = new MySqlConnection(stringConecction);

        // Instancia de la clase Validaciones
        Validaciones validacion = new Validaciones();

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.validarNumeros(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Alamacenamos en variables de tipo string el contenido de cada TextBox
            string idMedico = textBox1.Text;

            if (idMedico == "")
            {
                MessageBox.Show("Debe llenar el campo de busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                // Query con la instrucción SQL a ejecutar
                string query = "SELECT * FROM tbmedicos WHERE IdMedico=" + idMedico + "";

                // Instanciamos un objeto MySqlCommand que recibirá por parametro el query y el objeto global de conexión
                MySqlCommand comando = new MySqlCommand(query, myConnection);

                // Instanciamos un objeto de la clase MySqlAdapter
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();

                // Instanciamos un objeto de la clase DataTable
                DataTable tabla = new DataTable();

                try
                {
                    // Abrimos la conexión
                    myConnection.Open();

                    myAdapter.SelectCommand = comando;
                    myAdapter.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                    
                    // Cerramos la conexión
                    myConnection.Close();

                }
                catch 
                {
                    MessageBox.Show("Error de conexión", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Alamacenamos en variables de tipo string el contenido de cada TextBox
            string idMedico = textBox1.Text;

            if (idMedico == "")
            {
                MessageBox.Show("Debe buscar primero al medico para darlo de baja", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
