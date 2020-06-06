namespace Consultorio_Medico
{
    partial class MenuCon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCon));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.citasProgramadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarUnaCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeCitasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarUnPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasProgramadasToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.pacientesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // citasProgramadasToolStripMenuItem
            // 
            this.citasProgramadasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarseToolStripMenuItem});
            this.citasProgramadasToolStripMenuItem.Name = "citasProgramadasToolStripMenuItem";
            this.citasProgramadasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.citasProgramadasToolStripMenuItem.Text = "Usuarios";
            this.citasProgramadasToolStripMenuItem.Click += new System.EventHandler(this.citasProgramadasToolStripMenuItem_Click);
            // 
            // registrarseToolStripMenuItem
            // 
            this.registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            this.registrarseToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.registrarseToolStripMenuItem.Text = "Datos de los usuarios";
            this.registrarseToolStripMenuItem.Click += new System.EventHandler(this.registrarseToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarUnaCitaToolStripMenuItem,
            this.datosDeCitasToolStripMenuItem1});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.pacientesToolStripMenuItem.Text = "Módulo de citas";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // agendarUnaCitaToolStripMenuItem
            // 
            this.agendarUnaCitaToolStripMenuItem.Name = "agendarUnaCitaToolStripMenuItem";
            this.agendarUnaCitaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.agendarUnaCitaToolStripMenuItem.Text = "Agendar una cita";
            this.agendarUnaCitaToolStripMenuItem.Click += new System.EventHandler(this.agendarUnaCitaToolStripMenuItem_Click);
            // 
            // datosDeCitasToolStripMenuItem1
            // 
            this.datosDeCitasToolStripMenuItem1.Name = "datosDeCitasToolStripMenuItem1";
            this.datosDeCitasToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.datosDeCitasToolStripMenuItem1.Text = "Datos de las citas";
            this.datosDeCitasToolStripMenuItem1.Click += new System.EventHandler(this.datosDeCitasToolStripMenuItem1_Click);
            // 
            // pacientesToolStripMenuItem1
            // 
            this.pacientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarUnPacienteToolStripMenuItem,
            this.datosDePacientesToolStripMenuItem});
            this.pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";
            this.pacientesToolStripMenuItem1.Size = new System.Drawing.Size(130, 20);
            this.pacientesToolStripMenuItem1.Text = "Módulo de pacientes";
            // 
            // agendarUnPacienteToolStripMenuItem
            // 
            this.agendarUnPacienteToolStripMenuItem.Name = "agendarUnPacienteToolStripMenuItem";
            this.agendarUnPacienteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.agendarUnPacienteToolStripMenuItem.Text = "Agendar un paciente";
            this.agendarUnPacienteToolStripMenuItem.Click += new System.EventHandler(this.agendarUnPacienteToolStripMenuItem_Click);
            // 
            // datosDePacientesToolStripMenuItem
            // 
            this.datosDePacientesToolStripMenuItem.Name = "datosDePacientesToolStripMenuItem";
            this.datosDePacientesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.datosDePacientesToolStripMenuItem.Text = "Datos de los pacientes";
            this.datosDePacientesToolStripMenuItem.Click += new System.EventHandler(this.datosDePacientesToolStripMenuItem_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(685, 507);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(303, 25);
            this.lbFecha.TabIndex = 6;
            this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
            this.lbFecha.Click += new System.EventHandler(this.lbFecha_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(771, 440);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(205, 54);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "21:49:45";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 548);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuCon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripMenuItem citasProgramadasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem registrarseToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem datosDePacientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem datosDeCitasToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem agendarUnaCitaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem agendarUnPacienteToolStripMenuItem;
    }
}