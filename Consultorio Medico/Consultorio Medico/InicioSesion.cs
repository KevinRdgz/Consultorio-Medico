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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Consultorio Medico;User ID=;Password=");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Login WHERE Usuario='" + Txtuser.Text + "' AND Password='" + Txtpass.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    MessageBox.Show("Bienvenido al sistema de registro de consultas medicas");

                    MenuCon m = new MenuCon();
                    m.ShowDialog();

                }
                else
                    MessageBox.Show("Usuario no autorizado!");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(Txtuser.Text) &&
                !string.IsNullOrEmpty(Txtpass.Text);
            btnaceptar.Enabled = vr;
        }

        private void Txtuser_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void Txtpass_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnaceptar.Enabled = false;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


