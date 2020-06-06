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
    public partial class EditarPacientes : Form
    {
        public static int dondeestala_id;

        public EditarPacientes()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Consultorio Medico;User ID=;Password=";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); using (SqlCommand cmd = new SqlCommand("UPDATE Pacientes SET Nombres=@Nombres, Apellidos=@Apellidos, Edad= @Edad, Telefono= @Telefono, Direccion=@Direccion " + " WHERE Id='" + dondeestala_id + "' ", conn))
                {
                    cmd.Parameters.AddWithValue("@Nombres", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
                    cmd.Parameters.AddWithValue("@Edad", txtedad.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txttelefono.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtdireccion.Text);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        

        private void EditarPacientes_Load(object sender, EventArgs e)
        {
            Text = dondeestala_id.ToString();
            Actualizar();
        }
        
        

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
