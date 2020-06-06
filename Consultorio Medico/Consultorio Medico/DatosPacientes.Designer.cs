namespace Consultorio_Medico
{
    partial class DatosPacientes
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
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorio_MedicoDataSet = new Consultorio_Medico.Consultorio_MedicoDataSet();
            this.pacientesTableAdapter = new Consultorio_Medico.Consultorio_MedicoDataSetTableAdapters.PacientesTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_MedicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.consultorio_MedicoDataSet;
            // 
            // consultorio_MedicoDataSet
            // 
            this.consultorio_MedicoDataSet.DataSetName = "Consultorio_MedicoDataSet";
            this.consultorio_MedicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(688, 155);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(92, 28);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(688, 107);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 28);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nombresDataGridViewTextBoxColumn1,
            this.apellidosDataGridViewTextBoxColumn1,
            this.edadDataGridViewTextBoxColumn1,
            this.telefonoDataGridViewTextBoxColumn1,
            this.direccionDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.pacientesBindingSource;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dataGridView2.Location = new System.Drawing.Point(13, 100);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(642, 289);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn1
            // 
            this.nombresDataGridViewTextBoxColumn1.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn1.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn1.Name = "nombresDataGridViewTextBoxColumn1";
            // 
            // apellidosDataGridViewTextBoxColumn1
            // 
            this.apellidosDataGridViewTextBoxColumn1.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn1.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn1.Name = "apellidosDataGridViewTextBoxColumn1";
            // 
            // edadDataGridViewTextBoxColumn1
            // 
            this.edadDataGridViewTextBoxColumn1.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn1.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn1.Name = "edadDataGridViewTextBoxColumn1";
            // 
            // telefonoDataGridViewTextBoxColumn1
            // 
            this.telefonoDataGridViewTextBoxColumn1.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn1.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn1.Name = "telefonoDataGridViewTextBoxColumn1";
            // 
            // direccionDataGridViewTextBoxColumn1
            // 
            this.direccionDataGridViewTextBoxColumn1.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn1.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn1.Name = "direccionDataGridViewTextBoxColumn1";
            // 
            // btncerrar
            // 
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(688, 207);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(88, 28);
            this.btncerrar.TabIndex = 13;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 39);
            this.label3.TabIndex = 39;
            this.label3.Text = "Datos de pacientes";
            // 
            // DatosPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.textBox1);
            this.Name = "DatosPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de pacientes";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_MedicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Consultorio_MedicoDataSet consultorio_MedicoDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private Consultorio_MedicoDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label label3;
    }
}