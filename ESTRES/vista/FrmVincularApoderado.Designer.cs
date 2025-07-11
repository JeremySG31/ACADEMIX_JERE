namespace Academix.vista
{
    partial class FrmVincularApoderado
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
            this.grpListadoBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBuscar2 = new System.Windows.Forms.TextBox();
            this.cbBuscarColumna = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.grpDatosPrincipales = new System.Windows.Forms.GroupBox();
            this.cbApoderado = new System.Windows.Forms.ComboBox();
            this.cbEstudiante = new System.Windows.Forms.ComboBox();
            this.cbPrioridad = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParentesco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVinculo = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.grpInformacionAdicional = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cbIdEliminar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIdModificar = new System.Windows.Forms.ComboBox();
            this.grpListadoBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grpDatosPrincipales.SuspendLayout();
            this.grpInformacionAdicional.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListadoBusqueda
            // 
            this.grpListadoBusqueda.Controls.Add(this.txtBuscar2);
            this.grpListadoBusqueda.Controls.Add(this.cbBuscarColumna);
            this.grpListadoBusqueda.Controls.Add(this.txtBuscar);
            this.grpListadoBusqueda.Controls.Add(this.dgvUsuarios);
            this.grpListadoBusqueda.Controls.Add(this.label1);
            this.grpListadoBusqueda.Location = new System.Drawing.Point(744, 22);
            this.grpListadoBusqueda.Name = "grpListadoBusqueda";
            this.grpListadoBusqueda.Size = new System.Drawing.Size(737, 450);
            this.grpListadoBusqueda.TabIndex = 5;
            this.grpListadoBusqueda.TabStop = false;
            this.grpListadoBusqueda.Text = "LISTADO Y BUSQUEDA";
            // 
            // txtBuscar2
            // 
            this.txtBuscar2.Location = new System.Drawing.Point(483, 19);
            this.txtBuscar2.Name = "txtBuscar2";
            this.txtBuscar2.Size = new System.Drawing.Size(230, 22);
            this.txtBuscar2.TabIndex = 5;
            // 
            // cbBuscarColumna
            // 
            this.cbBuscarColumna.Location = new System.Drawing.Point(70, 17);
            this.cbBuscarColumna.Name = "cbBuscarColumna";
            this.cbBuscarColumna.Size = new System.Drawing.Size(140, 24);
            this.cbBuscarColumna.TabIndex = 1;
            this.cbBuscarColumna.SelectedIndexChanged += new System.EventHandler(this.cbBuscarColumna_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(247, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(230, 22);
            this.txtBuscar.TabIndex = 2;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.ColumnHeadersHeight = 29;
            this.dgvUsuarios.Location = new System.Drawing.Point(13, 45);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.Size = new System.Drawing.Size(718, 399);
            this.dgvUsuarios.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnInsertar);
            this.groupBox3.Location = new System.Drawing.Point(478, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 265);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACCIONES";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Location = new System.Drawing.Point(16, 184);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(216, 53);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar vinculo estudiante-apoderado";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Transparent;
            this.btnModificar.Location = new System.Drawing.Point(16, 102);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(216, 54);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar vinculo estudiante-apoderado";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(16, 29);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(216, 54);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Registrar nuevo vinculo estudiante-apoderado";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click_1);
            // 
            // grpDatosPrincipales
            // 
            this.grpDatosPrincipales.Controls.Add(this.cbApoderado);
            this.grpDatosPrincipales.Controls.Add(this.cbEstudiante);
            this.grpDatosPrincipales.Controls.Add(this.cbPrioridad);
            this.grpDatosPrincipales.Controls.Add(this.cbEstado);
            this.grpDatosPrincipales.Controls.Add(this.label5);
            this.grpDatosPrincipales.Controls.Add(this.label4);
            this.grpDatosPrincipales.Controls.Add(this.txtParentesco);
            this.grpDatosPrincipales.Controls.Add(this.label3);
            this.grpDatosPrincipales.Controls.Add(this.label2);
            this.grpDatosPrincipales.Controls.Add(this.label6);
            this.grpDatosPrincipales.Controls.Add(this.txtVinculo);
            this.grpDatosPrincipales.Controls.Add(this.lblNombres);
            this.grpDatosPrincipales.Location = new System.Drawing.Point(48, 22);
            this.grpDatosPrincipales.Name = "grpDatosPrincipales";
            this.grpDatosPrincipales.Size = new System.Drawing.Size(409, 287);
            this.grpDatosPrincipales.TabIndex = 13;
            this.grpDatosPrincipales.TabStop = false;
            this.grpDatosPrincipales.Text = "DATOS PRINCIPALES";
            // 
            // cbApoderado
            // 
            this.cbApoderado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApoderado.FormattingEnabled = true;
            this.cbApoderado.Location = new System.Drawing.Point(166, 121);
            this.cbApoderado.Name = "cbApoderado";
            this.cbApoderado.Size = new System.Drawing.Size(231, 24);
            this.cbApoderado.TabIndex = 30;
            // 
            // cbEstudiante
            // 
            this.cbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstudiante.FormattingEnabled = true;
            this.cbEstudiante.Location = new System.Drawing.Point(165, 72);
            this.cbEstudiante.Name = "cbEstudiante";
            this.cbEstudiante.Size = new System.Drawing.Size(231, 24);
            this.cbEstudiante.TabIndex = 29;
            // 
            // cbPrioridad
            // 
            this.cbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrioridad.FormattingEnabled = true;
            this.cbPrioridad.Items.AddRange(new object[] {
            "1 - Muy baja",
            "2 - Baja",
            "3 - Media",
            "4 - Alta",
            "5 - Muy alta"});
            this.cbPrioridad.Location = new System.Drawing.Point(165, 199);
            this.cbPrioridad.Name = "cbPrioridad";
            this.cbPrioridad.Size = new System.Drawing.Size(231, 24);
            this.cbPrioridad.TabIndex = 28;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(166, 227);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(231, 24);
            this.cbEstado.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Prioridad:";
            // 
            // txtParentesco
            // 
            this.txtParentesco.Location = new System.Drawing.Point(166, 150);
            this.txtParentesco.Name = "txtParentesco";
            this.txtParentesco.Size = new System.Drawing.Size(231, 22);
            this.txtParentesco.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Parentesco:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID Apoderado:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID Vinculo:";
            // 
            // txtVinculo
            // 
            this.txtVinculo.Location = new System.Drawing.Point(165, 45);
            this.txtVinculo.Name = "txtVinculo";
            this.txtVinculo.Size = new System.Drawing.Size(231, 22);
            this.txtVinculo.TabIndex = 1;
            // 
            // lblNombres
            // 
            this.lblNombres.Location = new System.Drawing.Point(23, 73);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(100, 23);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "ID Estudiante:";
            // 
            // grpInformacionAdicional
            // 
            this.grpInformacionAdicional.Controls.Add(this.lblRol);
            this.grpInformacionAdicional.Controls.Add(this.cbIdEliminar);
            this.grpInformacionAdicional.Location = new System.Drawing.Point(48, 403);
            this.grpInformacionAdicional.Name = "grpInformacionAdicional";
            this.grpInformacionAdicional.Size = new System.Drawing.Size(409, 69);
            this.grpInformacionAdicional.TabIndex = 45;
            this.grpInformacionAdicional.TabStop = false;
            this.grpInformacionAdicional.Text = "ELIMINAR";
            // 
            // lblRol
            // 
            this.lblRol.Location = new System.Drawing.Point(10, 20);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(142, 23);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Seleccione el ID:";
            // 
            // cbIdEliminar
            // 
            this.cbIdEliminar.Location = new System.Drawing.Point(158, 17);
            this.cbIdEliminar.Name = "cbIdEliminar";
            this.cbIdEliminar.Size = new System.Drawing.Size(213, 24);
            this.cbIdEliminar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbIdModificar);
            this.groupBox1.Location = new System.Drawing.Point(48, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 69);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " MODIFICAR";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Seleccione el ID:";
            // 
            // cbIdModificar
            // 
            this.cbIdModificar.Location = new System.Drawing.Point(158, 17);
            this.cbIdModificar.Name = "cbIdModificar";
            this.cbIdModificar.Size = new System.Drawing.Size(213, 24);
            this.cbIdModificar.TabIndex = 1;
            // 
            // FrmVincularApoderado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpInformacionAdicional);
            this.Controls.Add(this.grpDatosPrincipales);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpListadoBusqueda);
            this.Name = "FrmVincularApoderado";
            this.Text = "FrmVincularApoderado";
            this.grpListadoBusqueda.ResumeLayout(false);
            this.grpListadoBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.grpDatosPrincipales.ResumeLayout(false);
            this.grpDatosPrincipales.PerformLayout();
            this.grpInformacionAdicional.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListadoBusqueda;
        private System.Windows.Forms.ComboBox cbBuscarColumna;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscar2;
        private System.Windows.Forms.GroupBox grpDatosPrincipales;
        private System.Windows.Forms.ComboBox cbApoderado;
        private System.Windows.Forms.ComboBox cbEstudiante;
        private System.Windows.Forms.ComboBox cbPrioridad;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParentesco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtVinculo;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grpInformacionAdicional;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cbIdEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbIdModificar;
    }
}