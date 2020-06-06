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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }

        string cs = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Consultorio Medico;User ID=;Password=";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        private void Citas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'consultorio_MedicoDataSet3.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.Fill(this.consultorio_MedicoDataSet3.Citas);
            llenargrid();
        }

        public void llenargrid()
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Citas", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Citas where Nombres like '" + textBox1.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaCita c = new NuevaCita();
            c.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EditarCitas ec = new EditarCitas();
            ec.ShowDialog();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("¿Quieres eliminar el registro?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Citas " +
                    "WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
