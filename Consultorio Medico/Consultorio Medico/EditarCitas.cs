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
    public partial class EditarCitas : Form
    {
        public static int dondeestala_id;

        public EditarCitas()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            string lafecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Consultorio Medico;User ID=;Password="; 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); using (SqlCommand cmd = new SqlCommand("UPDATE Citas SET Nombres=@Nombres, Apellidos=@Apellidos, Especialidad= @Especialidad, Especialista= @Especialista, Fecha=@Fecha " +" WHERE Id='" + dondeestala_id + "' ", conn))
                {
                    cmd.Parameters.AddWithValue("@Nombres", txtNombre.Text); 
                    cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text); 
                    cmd.Parameters.AddWithValue("@Especialidad", txtespecialidad.Text); 
                    cmd.Parameters.AddWithValue("@Especialista", txtespecialista.Text); 
                    cmd.Parameters.AddWithValue("@Fecha", lafecha); 
                    int rows = cmd.ExecuteNonQuery(); }
            }
        }

        private void EditarCitas_Load(object sender, EventArgs e)
        {
            Text = dondeestala_id.ToString();
            Actualizar();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
           Actualizar();
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
