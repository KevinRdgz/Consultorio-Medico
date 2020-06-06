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
    public partial class NuevoPaciente : Form
    {
        public NuevoPaciente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo()
        {
            var connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Consultorio Medico;User ID=;Password=";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmdText = "INSERT INTO Pacientes VALUES (@Nombres, @Apellidos, @Edad, @Telefono, @Direccion)";
                var cmd = new SqlCommand(cmdText, conn);
                if (txtNombre.Text != "" && txtApellidos.Text != "")
                {
                    cmd.Parameters.AddWithValue("@Nombres", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
                    cmd.Parameters.AddWithValue("@Edad", txtedad.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txttelefono.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtdireccion.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registrado correctamente");
                    txtNombre.Clear();
                    txtApellidos.Clear();
                    txtedad.Clear();
                    txttelefono.Clear();
                    txtdireccion.Clear();

                }
                else
                {
                    MessageBox.Show("Debe introducir nombre y apellidos");

                }
            }
        }

        private void NuevoPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
