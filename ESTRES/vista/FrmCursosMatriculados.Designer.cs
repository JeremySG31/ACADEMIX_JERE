namespace Academix.vista
{
    partial class FrmCursosMatriculados
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btLimpiarCampos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.grpListadoBusqueda = new System.Windows.Forms.GroupBox();
            this.cbBuscarColumna = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvCursosMatriculados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIdModificar = new System.Windows.Forms.ComboBox();
            this.grpInformacionAdicional = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cbIdEliminar = new System.Windows.Forms.ComboBox();
            this.grpDatosPrincipales = new System.Windows.Forms.GroupBox();
            this.cbEstudiantes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCursoMatriculado = new System.Windows.Forms.TextBox();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIdMatricula = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.grpListadoBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosMatriculados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpInformacionAdicional.SuspendLayout();
            this.grpDatosPrincipales.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btLimpiarCampos);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnInsertar);
            this.groupBox3.Location = new System.Drawing.Point(489, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 355);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACCIONES";
            // 
            // btLimpiarCampos
            // 
            this.btLimpiarCampos.BackColor = System.Drawing.Color.Snow;
            this.btLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiarCampos.ForeColor = System.Drawing.Color.Black;
            this.btLimpiarCampos.Location = new System.Drawing.Point(31, 275);
            this.btLimpiarCampos.Name = "btLimpiarCampos";
            this.btLimpiarCampos.Size = new System.Drawing.Size(178, 46);
            this.btLimpiarCampos.TabIndex = 51;
            this.btLimpiarCampos.Text = "Limpiar campos";
            this.btLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(31, 198);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(178, 51);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar curso matriculado";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(31, 124);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(178, 51);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar curso matriculado";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(31, 45);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(178, 56);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Registrar nuevo curso matriculado";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // grpListadoBusqueda
            // 
            this.grpListadoBusqueda.Controls.Add(this.cbBuscarColumna);
            this.grpListadoBusqueda.Controls.Add(this.txtBuscar);
            this.grpListadoBusqueda.Controls.Add(this.dgvCursosMatriculados);
            this.grpListadoBusqueda.Controls.Add(this.label1);
            this.grpListadoBusqueda.Location = new System.Drawing.Point(745, 32);
            this.grpListadoBusqueda.Name = "grpListadoBusqueda";
            this.grpListadoBusqueda.Size = new System.Drawing.Size(746, 449);
            this.grpListadoBusqueda.TabIndex = 10;
            this.grpListadoBusqueda.TabStop = false;
            this.grpListadoBusqueda.Text = "LISTADO Y BÚSQUEDA";
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
            // dgvCursosMatriculados
            // 
            this.dgvCursosMatriculados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCursosMatriculados.ColumnHeadersHeight = 29;
            this.dgvCursosMatriculados.Location = new System.Drawing.Point(13, 55);
            this.dgvCursosMatriculados.Name = "dgvCursosMatriculados";
            this.dgvCursosMatriculados.RowHeadersWidth = 51;
            this.dgvCursosMatriculados.Size = new System.Drawing.Size(713, 378);
            this.dgvCursosMatriculados.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbIdModificar);
            this.groupBox1.Location = new System.Drawing.Point(56, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 56);
            this.groupBox1.TabIndex = 60;
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
            this.cbIdModificar.Size = new System.Drawing.Size(238, 24);
            this.cbIdModificar.TabIndex = 1;
            // 
            // grpInformacionAdicional
            // 
            this.grpInformacionAdicional.Controls.Add(this.lblRol);
            this.grpInformacionAdicional.Controls.Add(this.cbIdEliminar);
            this.grpInformacionAdicional.Location = new System.Drawing.Point(56, 357);
            this.grpInformacionAdicional.Name = "grpInformacionAdicional";
            this.grpInformacionAdicional.Size = new System.Drawing.Size(409, 55);
            this.grpInformacionAdicional.TabIndex = 59;
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
            this.cbIdEliminar.Size = new System.Drawing.Size(238, 24);
            this.cbIdEliminar.TabIndex = 1;
            // 
            // grpDatosPrincipales
            // 
            this.grpDatosPrincipales.Controls.Add(this.cbEstudiantes);
            this.grpDatosPrincipales.Controls.Add(this.label4);
            this.grpDatosPrincipales.Controls.Add(this.txtCursoMatriculado);
            this.grpDatosPrincipales.Controls.Add(this.cbCursos);
            this.grpDatosPrincipales.Controls.Add(this.label2);
            this.grpDatosPrincipales.Controls.Add(this.cbIdMatricula);
            this.grpDatosPrincipales.Controls.Add(this.label3);
            this.grpDatosPrincipales.Controls.Add(this.label6);
            this.grpDatosPrincipales.Location = new System.Drawing.Point(56, 87);
            this.grpDatosPrincipales.Name = "grpDatosPrincipales";
            this.grpDatosPrincipales.Size = new System.Drawing.Size(409, 162);
            this.grpDatosPrincipales.TabIndex = 58;
            this.grpDatosPrincipales.TabStop = false;
            this.grpDatosPrincipales.Text = "DATOS PRINCIPALES";
            // 
            // cbEstudiantes
            // 
            this.cbEstudiantes.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbEstudiantes.Location = new System.Drawing.Point(164, 124);
            this.cbEstudiantes.Name = "cbEstudiantes";
            this.cbEstudiantes.Size = new System.Drawing.Size(231, 24);
            this.cbEstudiantes.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "ID Estudiante:";
            // 
            // txtCursoMatriculado
            // 
            this.txtCursoMatriculado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCursoMatriculado.Location = new System.Drawing.Point(165, 25);
            this.txtCursoMatriculado.MaxLength = 5;
            this.txtCursoMatriculado.Name = "txtCursoMatriculado";
            this.txtCursoMatriculado.Size = new System.Drawing.Size(230, 22);
            this.txtCursoMatriculado.TabIndex = 5;
            // 
            // cbCursos
            // 
            this.cbCursos.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbCursos.Location = new System.Drawing.Point(165, 89);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(231, 24);
            this.cbCursos.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "ID Curso Matriculado:";
            // 
            // cbIdMatricula
            // 
            this.cbIdMatricula.Location = new System.Drawing.Point(165, 57);
            this.cbIdMatricula.Name = "cbIdMatricula";
            this.cbIdMatricula.Size = new System.Drawing.Size(231, 24);
            this.cbIdMatricula.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Curso:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID Matricula:";
            // 
            // FrmCursosMatriculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpInformacionAdicional);
            this.Controls.Add(this.grpDatosPrincipales);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpListadoBusqueda);
            this.Name = "FrmCursosMatriculados";
            this.Text = "FrmCursosMatriculados";
            this.groupBox3.ResumeLayout(false);
            this.grpListadoBusqueda.ResumeLayout(false);
            this.grpListadoBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosMatriculados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grpInformacionAdicional.ResumeLayout(false);
            this.grpDatosPrincipales.ResumeLayout(false);
            this.grpDatosPrincipales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.GroupBox grpListadoBusqueda;
        private System.Windows.Forms.ComboBox cbBuscarColumna;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvCursosMatriculados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbIdModificar;
        private System.Windows.Forms.GroupBox grpInformacionAdicional;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cbIdEliminar;
        private System.Windows.Forms.GroupBox grpDatosPrincipales;
        private System.Windows.Forms.ComboBox cbEstudiantes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCursoMatriculado;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIdMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btLimpiarCampos;
    }
}