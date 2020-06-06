using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio_Medico
{
    public partial class MenuCon : Form
    {
        public static MenuCon mdiobj;
        
        public MenuCon()
        {
            InitializeComponent();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void citasProgramadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCita nc = new NuevaCita();
            nc.ShowDialog();
        }

        private void datosDeCitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Citas c = new Citas();
            c.ShowDialog();
        }

        private void datosDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosPacientes dp = new DatosPacientes();
            dp.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void lbFecha_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.ShowDialog();
        }

        private void agendarUnaCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCita c = new NuevaCita();
            c.ShowDialog();
        }

        private void agendarUnPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoPaciente np = new NuevoPaciente();
            np.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

