namespace ESTRES.vista
{
    partial class FrmMatricula
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
            this.textBuscar2 = new System.Windows.Forms.TextBox();
            this.cbBuscarColumna = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btLimpiarCampos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIdModificar = new System.Windows.Forms.ComboBox();
            this.grpInformacionAdicional = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cbIdEliminar = new System.Windows.Forms.ComboBox();
            this.grpDatosPrincipales = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbAñoLectivo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbIdApoderado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdMatricula = new System.Windows.Forms.TextBox();
            this.cbGrados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstudiantes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpListadoBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpInformacionAdicional.SuspendLayout();
            this.grpDatosPrincipales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListadoBusqueda
            // 
            this.grpListadoBusqueda.Controls.Add(this.textBuscar2);
            this.grpListadoBusqueda.Controls.Add(this.cbBuscarColumna);
            this.grpListadoBusqueda.Controls.Add(this.txtBuscar);
            this.grpListadoBusqueda.Controls.Add(this.dgvUsuarios);
            this.grpListadoBusqueda.Controls.Add(this.label1);
            this.grpListadoBusqueda.Location = new System.Drawing.Point(684, 11);
            this.grpListadoBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpListadoBusqueda.Name = "grpListadoBusqueda";
            this.grpListadoBusqueda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpListadoBusqueda.Size = new System.Drawing.Size(843, 469);
            this.grpListadoBusqueda.TabIndex = 7;
            this.grpListadoBusqueda.TabStop = false;
            this.grpListadoBusqueda.Text = "LISTADO Y BÚSQUEDA";
            // 
            // textBuscar2
            // 
            this.textBuscar2.Location = new System.Drawing.Point(381, 18);
            this.textBuscar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBuscar2.Name = "textBuscar2";
            this.textBuscar2.Size = new System.Drawing.Size(177, 22);
            this.textBuscar2.TabIndex = 5;
            // 
            // cbBuscarColumna
            // 
            this.cbBuscarColumna.Location = new System.Drawing.Point(69, 17);
            this.cbBuscarColumna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBuscarColumna.Name = "cbBuscarColumna";
            this.cbBuscarColumna.Size = new System.Drawing.Size(140, 24);
            this.cbBuscarColumna.TabIndex = 1;
            this.cbBuscarColumna.SelectedIndexChanged += new System.EventHandler(this.cbBuscarColumna_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(247, 18);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(119, 22);
            this.txtBuscar.TabIndex = 2;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.ColumnHeadersHeight = 29;
            this.dgvUsuarios.Location = new System.Drawing.Point(11, 46);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.Size = new System.Drawing.Size(823, 414);
            this.dgvUsuarios.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btLimpiarCampos);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnInsertar);
            this.groupBox3.Location = new System.Drawing.Point(429, 85);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(243, 342);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACCIONES";
            // 
            // btLimpiarCampos
            // 
            this.btLimpiarCampos.BackColor = System.Drawing.Color.Snow;
            this.btLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiarCampos.ForeColor = System.Drawing.Color.Black;
            this.btLimpiarCampos.Location = new System.Drawing.Point(31, 270);
            this.btLimpiarCampos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpiarCampos.Name = "btLimpiarCampos";
            this.btLimpiarCampos.Size = new System.Drawing.Size(179, 46);
            this.btLimpiarCampos.TabIndex = 52;
            this.btLimpiarCampos.Text = "Limpiar campos";
            this.btLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(31, 206);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(179, 43);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar matricula";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(31, 132);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(179, 43);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar matricula";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(31, 53);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(179, 48);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Registrar nueva matricula";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbIdModificar);
            this.groupBox1.Location = new System.Drawing.Point(15, 359);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(399, 57);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " MODIFICAR";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Seleccione el ID:";
            // 
            // cbIdModificar
            // 
            this.cbIdModificar.Location = new System.Drawing.Point(157, 17);
            this.cbIdModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIdModificar.Name = "cbIdModificar";
            this.cbIdModificar.Size = new System.Drawing.Size(239, 24);
            this.cbIdModificar.TabIndex = 1;
            // 
            // grpInformacionAdicional
            // 
            this.grpInformacionAdicional.Controls.Add(this.lblRol);
            this.grpInformacionAdicional.Controls.Add(this.cbIdEliminar);
            this.grpInformacionAdicional.Location = new System.Drawing.Point(15, 421);
            this.grpInformacionAdicional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformacionAdicional.Name = "grpInformacionAdicional";
            this.grpInformacionAdicional.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformacionAdicional.Size = new System.Drawing.Size(399, 55);
            this.grpInformacionAdicional.TabIndex = 62;
            this.grpInformacionAdicional.TabStop = false;
            this.grpInformacionAdicional.Text = "ELIMINAR";
            // 
            // lblRol
            // 
            this.lblRol.Location = new System.Drawing.Point(11, 20);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(141, 23);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Seleccione el ID:";
            // 
            // cbIdEliminar
            // 
            this.cbIdEliminar.Location = new System.Drawing.Point(157, 17);
            this.cbIdEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIdEliminar.Name = "cbIdEliminar";
            this.cbIdEliminar.Size = new System.Drawing.Size(239, 24);
            this.cbIdEliminar.TabIndex = 1;
            // 
            // grpDatosPrincipales
            // 
            this.grpDatosPrincipales.Controls.Add(this.cbEstado);
            this.grpDatosPrincipales.Controls.Add(this.label11);
            this.grpDatosPrincipales.Controls.Add(this.cbAñoLectivo);
            this.grpDatosPrincipales.Controls.Add(this.label10);
            this.grpDatosPrincipales.Controls.Add(this.cbTurno);
            this.grpDatosPrincipales.Controls.Add(this.label9);
            this.grpDatosPrincipales.Controls.Add(this.cbSeccion);
            this.grpDatosPrincipales.Controls.Add(this.label8);
            this.grpDatosPrincipales.Controls.Add(this.cbIdApoderado);
            this.grpDatosPrincipales.Controls.Add(this.label5);
            this.grpDatosPrincipales.Controls.Add(this.fechaMatricula);
            this.grpDatosPrincipales.Controls.Add(this.label4);
            this.grpDatosPrincipales.Controls.Add(this.txtIdMatricula);
            this.grpDatosPrincipales.Controls.Add(this.cbGrados);
            this.grpDatosPrincipales.Controls.Add(this.label2);
            this.grpDatosPrincipales.Controls.Add(this.cbEstudiantes);
            this.grpDatosPrincipales.Controls.Add(this.label3);
            this.grpDatosPrincipales.Controls.Add(this.label6);
            this.grpDatosPrincipales.Location = new System.Drawing.Point(4, 28);
            this.grpDatosPrincipales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosPrincipales.Name = "grpDatosPrincipales";
            this.grpDatosPrincipales.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosPrincipales.Size = new System.Drawing.Size(409, 326);
            this.grpDatosPrincipales.TabIndex = 61;
            this.grpDatosPrincipales.TabStop = false;
            this.grpDatosPrincipales.Text = "DATOS PRINCIPALES";
            // 
            // cbEstado
            // 
            this.cbEstado.Location = new System.Drawing.Point(165, 244);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(231, 24);
            this.cbEstado.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(21, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 23);
            this.label11.TabIndex = 39;
            this.label11.Text = "Estado:";
            // 
            // cbAñoLectivo
            // 
            this.cbAñoLectivo.Location = new System.Drawing.Point(165, 213);
            this.cbAñoLectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAñoLectivo.Name = "cbAñoLectivo";
            this.cbAñoLectivo.Size = new System.Drawing.Size(231, 24);
            this.cbAñoLectivo.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(21, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 23);
            this.label10.TabIndex = 37;
            this.label10.Text = "ID Año lectivo:";
            // 
            // cbTurno
            // 
            this.cbTurno.Location = new System.Drawing.Point(165, 182);
            this.cbTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(231, 24);
            this.cbTurno.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(21, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "ID Turno:";
            // 
            // cbSeccion
            // 
            this.cbSeccion.Location = new System.Drawing.Point(165, 153);
            this.cbSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(231, 24);
            this.cbSeccion.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(21, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "ID Sección:";
            // 
            // cbIdApoderado
            // 
            this.cbIdApoderado.Location = new System.Drawing.Point(165, 122);
            this.cbIdApoderado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIdApoderado.Name = "cbIdApoderado";
            this.cbIdApoderado.Size = new System.Drawing.Size(231, 24);
            this.cbIdApoderado.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(21, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "ID Apoderado:";
            // 
            // fechaMatricula
            // 
            this.fechaMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaMatricula.Location = new System.Drawing.Point(165, 281);
            this.fechaMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fechaMatricula.Name = "fechaMatricula";
            this.fechaMatricula.Size = new System.Drawing.Size(231, 22);
            this.fechaMatricula.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha de Matricula:";
            // 
            // txtIdMatricula
            // 
            this.txtIdMatricula.Location = new System.Drawing.Point(165, 25);
            this.txtIdMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdMatricula.Name = "txtIdMatricula";
            this.txtIdMatricula.Size = new System.Drawing.Size(231, 22);
            this.txtIdMatricula.TabIndex = 5;
            // 
            // cbGrados
            // 
            this.cbGrados.Location = new System.Drawing.Point(165, 89);
            this.cbGrados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGrados.Name = "cbGrados";
            this.cbGrados.Size = new System.Drawing.Size(231, 24);
            this.cbGrados.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "ID Matricula:";
            // 
            // cbEstudiantes
            // 
            this.cbEstudiantes.Location = new System.Drawing.Point(165, 57);
            this.cbEstudiantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstudiantes.Name = "cbEstudiantes";
            this.cbEstudiantes.Size = new System.Drawing.Size(231, 24);
            this.cbEstudiantes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID Grado:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID Estudiante:";
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpInformacionAdicional);
            this.Controls.Add(this.grpDatosPrincipales);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpListadoBusqueda);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMatricula";
            this.Text = "FrmMatricula";
            this.grpListadoBusqueda.ResumeLayout(false);
            this.grpListadoBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpInformacionAdicional.ResumeLayout(false);
            this.grpDatosPrincipales.ResumeLayout(false);
            this.grpDatosPrincipales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpListadoBusqueda;
        private System.Windows.Forms.ComboBox cbBuscarColumna;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox textBuscar2;
        private System.Windows.Forms.Button btLimpiarCampos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbIdModificar;
        private System.Windows.Forms.GroupBox grpInformacionAdicional;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cbIdEliminar;
        private System.Windows.Forms.GroupBox grpDatosPrincipales;
        private System.Windows.Forms.DateTimePicker fechaMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdMatricula;
        private System.Windows.Forms.ComboBox cbGrados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstudiantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbAñoLectivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbIdApoderado;
        private System.Windows.Forms.Label label5;
    }
}