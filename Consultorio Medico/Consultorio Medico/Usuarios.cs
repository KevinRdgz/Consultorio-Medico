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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }


        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'consultorio_MedicoDataSet1.Login' Puede moverla o quitarla según sea necesario.
            this.loginTableAdapter.Fill(this.consultorio_MedicoDataSet1.Login);

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("¿Quieres eliminar el usuario?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Eliminar();
                    MessageBox.Show("Eliminado correctamente");
                }
            }

            else

                MessageBox.Show("Seleccione una fila");
        }

        public void Eliminar()

        {

            object ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string connectionString =
            "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Consultorio Medico;User ID=;Password=";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Login " + "WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RegistroSesion rs = new RegistroSesion();
            rs.ShowDialog();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
