﻿namespace ESTRES.vista
{
    partial class FrmCurso
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
            this.cbBuscarColumna = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.grpListadoBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpInformacionAdicional.SuspendLayout();
            this.grpDatosPrincipales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListadoBusqueda
            // 
            this.grpListadoBusqueda.Controls.Add(this.cbBuscarColumna);
            this.grpListadoBusqueda.Controls.Add(this.txtBuscar);
            this.grpListadoBusqueda.Controls.Add(this.dgvCursos);
            this.grpListadoBusqueda.Controls.Add(this.label1);
            this.grpListadoBusqueda.Location = new System.Drawing.Point(777, 24);
            this.grpListadoBusqueda.Name = "grpListadoBusqueda";
            this.grpListadoBusqueda.Size = new System.Drawing.Size(728, 457);
            this.grpListadoBusqueda.TabIndex = 6;
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
            // dgvCursos
            // 
            this.dgvCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCursos.ColumnHeadersHeight = 29;
            this.dgvCursos.Location = new System.Drawing.Point(10, 45);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.Size = new System.Drawing.Size(708, 402);
            this.dgvCursos.TabIndex = 3;
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
            this.groupBox3.Controls.Add(this.btLimpiarCampos);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnInsertar);
            this.groupBox3.Location = new System.Drawing.Point(503, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 319);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACCIONES";
            // 
            // btLimpiarCampos
            // 
            this.btLimpiarCampos.BackColor = System.Drawing.Color.Snow;
            this.btLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiarCampos.ForeColor = System.Drawing.Color.Black;
            this.btLimpiarCampos.Location = new System.Drawing.Point(31, 240);
            this.btLimpiarCampos.Name = "btLimpiarCampos";
            this.btLimpiarCampos.Size = new System.Drawing.Size(216, 53);
            this.btLimpiarCampos.TabIndex = 48;
            this.btLimpiarCampos.Text = "Limpiar campos";
            this.btLimpiarCampos.UseVisualStyleBackColor = false;
            this.btLimpiarCampos.Click += new System.EventHandler(this.btLimpiarCampos_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(31, 173);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(216, 50);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar curso";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(31, 107);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(216, 49);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar curso";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(31, 43);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(216, 48);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Registrar nuevo curso";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbIdModificar);
            this.groupBox1.Location = new System.Drawing.Point(49, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 69);
            this.groupBox1.TabIndex = 51;
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
            // grpInformacionAdicional
            // 
            this.grpInformacionAdicional.Controls.Add(this.lblRol);
            this.grpInformacionAdicional.Controls.Add(this.cbIdEliminar);
            this.grpInformacionAdicional.Location = new System.Drawing.Point(49, 359);
            this.grpInformacionAdicional.Name = "grpInformacionAdicional";
            this.grpInformacionAdicional.Size = new System.Drawing.Size(409, 69);
            this.grpInformacionAdicional.TabIndex = 50;
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
            // grpDatosPrincipales
            // 
            this.grpDatosPrincipales.Controls.Add(this.txtDescripcion);
            this.grpDatosPrincipales.Controls.Add(this.label4);
            this.grpDatosPrincipales.Controls.Add(this.txtCurso);
            this.grpDatosPrincipales.Controls.Add(this.label3);
            this.grpDatosPrincipales.Controls.Add(this.label6);
            this.grpDatosPrincipales.Controls.Add(this.txtIdCurso);
            this.grpDatosPrincipales.Location = new System.Drawing.Point(49, 77);
            this.grpDatosPrincipales.Name = "grpDatosPrincipales";
            this.grpDatosPrincipales.Size = new System.Drawing.Size(409, 169);
            this.grpDatosPrincipales.TabIndex = 49;
            this.grpDatosPrincipales.TabStop = false;
            this.grpDatosPrincipales.Text = "DATOS PRINCIPALES";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(165, 119);
            this.txtDescripcion.MaxLength = 10;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(231, 22);
            this.txtDescripcion.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descripción:";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(165, 79);
            this.txtCurso.MaxLength = 5;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(231, 22);
            this.txtCurso.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Curso:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID Curso:";
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdCurso.Location = new System.Drawing.Point(165, 45);
            this.txtIdCurso.MaxLength = 5;
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(231, 22);
            this.txtIdCurso.TabIndex = 1;
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpInformacionAdicional);
            this.Controls.Add(this.grpListadoBusqueda);
            this.Controls.Add(this.grpDatosPrincipales);
            this.Name = "FrmCurso";
            this.Text = "FrmCurso";
            this.grpListadoBusqueda.ResumeLayout(false);
            this.grpListadoBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btLimpiarCampos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbIdModificar;
        private System.Windows.Forms.GroupBox grpInformacionAdicional;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cbIdEliminar;
        private System.Windows.Forms.GroupBox grpDatosPrincipales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}