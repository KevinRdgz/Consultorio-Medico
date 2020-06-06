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
    public partial class DatosPacientes : Form
    {
        public DatosPacientes()
        {
            InitializeComponent();
        }

        string cs = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Consultorio Medico;User ID=;Password=";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'consultorio_MedicoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.consultorio_MedicoDataSet.Pacientes);

                llenargrid();
        }

        public void llenargrid()

        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Pacientes", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs); 
            con.Open();
            adapt = new SqlDataAdapter("select * from Pacientes where Nombres like '" + textBox1.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
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

            object ID = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            string connectionString =
            "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Consultorio Medico;User ID=;Password=";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Pacientes " + "WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
              NuevoPaciente p = new NuevoPaciente();
              p.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EditarPacientes ep = new EditarPacientes();
            ep.ShowDialog();
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


