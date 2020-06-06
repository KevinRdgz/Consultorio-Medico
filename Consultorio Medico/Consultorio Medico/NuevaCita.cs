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
    public partial class NuevaCita : Form
    {
        public NuevaCita()
        {
            InitializeComponent();
        }

        private void NuevaCita_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo()
        {
            string lafecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Consultorio Medico;User ID=;Password=";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmdText = "INSERT INTO Citas VALUES (@Nombres, @Apellidos, @Especialidad, @Especialista, @Fecha)";
                var cmd = new SqlCommand(cmdText, conn);
                if (txtNombre.Text != "" && txtApellidos.Text != "")
                {
                    cmd.Parameters.AddWithValue("@Nombres", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
                    cmd.Parameters.AddWithValue("@Especialidad", txtespecialidad.Text);
                    cmd.Parameters.AddWithValue("@Especialista", txtespecialista.Text);
                    cmd.Parameters.AddWithValue("@Fecha", lafecha);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registrado correctamente");
                    txtNombre.Clear();                   
                    txtApellidos.Clear();
                    txtespecialidad.Clear();
                    txtespecialista.Clear();


                }
                else
                {
                    MessageBox.Show("Debe introducir nombre y apellido");

                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (LocalDb)\\MSSQLLocalDB; Initial Catalog = Consultorio Medico; User ID =; Password = "); 
            string textoCmd = "SELECT * FROM  Citas";   
            //Abrir coneccion           
            con.Open();             
            //Ejecutar sentencia SQL  
            SqlCommand cmd = new SqlCommand(textoCmd, con); 
            SqlDataReader reader = cmd.ExecuteReader();    
            if (reader.HasRows)        
            {                 
                while (reader.Read()) 
                {                     
                    //Agrear información al combo   
                    comboBox1.Items.Add(reader["Especialista"].ToString());        
                }            
            }               
            con.Close();
        }
    }
}
