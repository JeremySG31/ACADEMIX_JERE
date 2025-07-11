namespace Academix.vista
{
    partial class FrmAsistenciaMatriculados
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTomar = new System.Windows.Forms.TabPage();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.chkT = new System.Windows.Forms.CheckBox();
            this.chkF = new System.Windows.Forms.CheckBox();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabTomar.SuspendLayout();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTomar);
            this.tabControl.Location = new System.Drawing.Point(33, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1067, 517);
            this.tabControl.TabIndex = 8;
            // 
            // tabTomar
            // 
            this.tabTomar.Controls.Add(this.groupBoxFiltros);
            this.tabTomar.Controls.Add(this.dgvAsistencia);
            this.tabTomar.Location = new System.Drawing.Point(4, 25);
            this.tabTomar.Name = "tabTomar";
            this.tabTomar.Size = new System.Drawing.Size(1059, 488);
            this.tabTomar.TabIndex = 0;
            this.tabTomar.Text = "Tomar Asistencia";
            this.tabTomar.UseVisualStyleBackColor = true;
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.label2);
            this.groupBoxFiltros.Controls.Add(this.label1);
            this.groupBoxFiltros.Controls.Add(this.lblNombre);
            this.groupBoxFiltros.Controls.Add(this.lblNivel);
            this.groupBoxFiltros.Controls.Add(this.chkA);
            this.groupBoxFiltros.Controls.Add(this.cbNivel);
            this.groupBoxFiltros.Controls.Add(this.chkT);
            this.groupBoxFiltros.Controls.Add(this.chkF);
            this.groupBoxFiltros.Controls.Add(this.cbGrado);
            this.groupBoxFiltros.Controls.Add(this.cbSeccion);
            this.groupBoxFiltros.Controls.Add(this.dtpFecha);
            this.groupBoxFiltros.Location = new System.Drawing.Point(20, 20);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(1022, 120);
            this.groupBoxFiltros.TabIndex = 11;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros de Asistencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(787, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "FECHA DE REGISTRO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "SECCIÓN:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(414, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 16);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = " GRADO:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(220, 30);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(54, 16);
            this.lblNivel.TabIndex = 12;
            this.lblNivel.Text = "NIVEL:";
            // 
            // chkA
            // 
            this.chkA.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkA.Location = new System.Drawing.Point(20, 30);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(40, 40);
            this.chkA.TabIndex = 1;
            this.chkA.Text = "A";
            this.chkA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Location = new System.Drawing.Point(223, 53);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(150, 24);
            this.cbNivel.TabIndex = 11;
            this.cbNivel.SelectedIndexChanged += new System.EventHandler(this.cbNivel_SelectedIndexChanged);
            // 
            // chkT
            // 
            this.chkT.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkT.Location = new System.Drawing.Point(70, 30);
            this.chkT.Name = "chkT";
            this.chkT.Size = new System.Drawing.Size(40, 40);
            this.chkT.TabIndex = 2;
            this.chkT.Text = "T";
            this.chkT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkT.UseVisualStyleBackColor = true;
            // 
            // chkF
            // 
            this.chkF.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkF.Location = new System.Drawing.Point(120, 30);
            this.chkF.Name = "chkF";
            this.chkF.Size = new System.Drawing.Size(40, 40);
            this.chkF.TabIndex = 3;
            this.chkF.Text = "F";
            this.chkF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkF.UseVisualStyleBackColor = true;
            // 
            // cbGrado
            // 
            this.cbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(417, 53);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(150, 24);
            this.cbGrado.TabIndex = 4;
            this.cbGrado.SelectedIndexChanged += new System.EventHandler(this.cbGrado_SelectedIndexChanged);
            // 
            // cbSeccion
            // 
            this.cbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeccion.FormattingEnabled = true;
            this.cbSeccion.Location = new System.Drawing.Point(610, 53);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(150, 24);
            this.cbSeccion.TabIndex = 5;
            this.cbSeccion.SelectedIndexChanged += new System.EventHandler(this.cbSeccion_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(790, 55);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 6;
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.AllowUserToAddRows = false;
            this.dgvAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Location = new System.Drawing.Point(20, 150);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.RowHeadersWidth = 51;
            this.dgvAsistencia.Size = new System.Drawing.Size(1022, 329);
            this.dgvAsistencia.TabIndex = 0;
            // 
            // FrmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 585);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmAsistenciaMatriculados";
            this.Text = "FrmAsistenciaMatriculados";
            this.tabControl.ResumeLayout(false);
            this.tabTomar.ResumeLayout(false);
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTomar;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.CheckBox chkT;
        private System.Windows.Forms.CheckBox chkF;
        private System.Windows.Forms.ComboBox cbGrado;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvAsistencia;
    }
}