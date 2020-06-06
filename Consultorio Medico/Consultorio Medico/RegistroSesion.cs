using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Consultorio_Medico
{
    public partial class RegistroSesion : Form
    {
        public RegistroSesion()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Consultorio Medico;User ID=;Password=");
            conn.Open();
            string insert_query = "insert into Login (Usuario,Password,Nombres,Apellidos) values (@Usuario ,@Password,@Nombres,@Apellidos)"; 
            SqlCommand cmd = new SqlCommand(insert_query, conn);
            cmd.Parameters.AddWithValue("@Nombres", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
            cmd.Parameters.AddWithValue("@Usuario", txtuser.Text); 
            cmd.Parameters.AddWithValue("@Password", txtpass.Text);
            MessageBox.Show("Usuario registrado con éxito");
            cmd.ExecuteNonQuery(); 
            conn.Close();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtuser.Text) &&
                !string.IsNullOrEmpty(txtpass.Text);
            btnregistrar.Enabled = vr;
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnregistrar.Enabled = false;
        }

        private void btnexistente_Click(object sender, EventArgs e)
        {
            InicioSesion K = new InicioSesion();
            K.ShowDialog();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
