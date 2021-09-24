using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Importamos MySql.Data.MySqlClient
using MySql.Data.MySqlClient;


namespace U2A1IDEISAC
{
    public partial class Form1 : Form
    {
        // Creamos string de conexión
        static private string stringConecction = "server=localhost; database=dbu3isac; user=root; password=1984Orwell*; SslMode=none";

        // Creamos objeto de conexión
        MySqlConnection myConnection = new MySqlConnection(stringConecction);

        // Creamos un onjeto de la clase que acabamos de crear "Validaciones"
        Validaciones validación = new Validaciones();

        public Form1()
        {
            InitializeComponent();
            customizedDesign();
        }
       
        // Escribimos el código en el método Form1_Load()
        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void customizedDesign() 
        {
            panelSubMenuMedicos.Visible = false;
            panelSubMenuPacientes.Visible = false;
        }

        

        private void showSubMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else 
            {
                subMenu.Visible = false;
            }
        }

        private void buttonMedicos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMedicos);
        }

        private void buttonPacientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuPacientes);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form formularioActivo = null;

        private void abrirFormularioHijo(Form formularioHijo) 
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(formularioHijo);
            panelChildForm.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void buttonAltasMedicos_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario "Alta de médico"
            abrirFormularioHijo(new Form2());
        }

        private void buttonBajasMedicos_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario "Baja de médico"
            abrirFormularioHijo(new Form3());
        }

        private void buttonModificarMedicos_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario "Modificar registro de médico"
            abrirFormularioHijo(new Form4());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario "Alta de paciente"
            abrirFormularioHijo(new Form5());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario "Baja de paciente"
            abrirFormularioHijo(new Form6());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario "Modificar registro de paciente"
            abrirFormularioHijo(new Form7());
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario "Consultas"
            abrirFormularioHijo(new Form8());
        }
    }
}
