namespace Academix.vista
{
    partial class FrmConsultarHistorialA
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
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.groupBoxFiltrosHistorial = new System.Windows.Forms.GroupBox();
            this.btnConsultarAsistencias = new System.Windows.Forms.Button();
            this.lblFechaHistorial = new System.Windows.Forms.Label();
            this.dtpFechaHistorial = new System.Windows.Forms.DateTimePicker();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHistorial.SuspendLayout();
            this.groupBoxFiltrosHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabHistorial
            // 
            this.tabHistorial.Controls.Add(this.groupBoxFiltrosHistorial);
            this.tabHistorial.Controls.Add(this.dgvHistorial);
            this.tabHistorial.Location = new System.Drawing.Point(4, 25);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Size = new System.Drawing.Size(1059, 488);
            this.tabHistorial.TabIndex = 1;
            this.tabHistorial.Text = "Historial de Asistencias";
            this.tabHistorial.UseVisualStyleBackColor = true;
            // 
            // groupBoxFiltrosHistorial
            // 
            this.groupBoxFiltrosHistorial.Controls.Add(this.btnConsultarAsistencias);
            this.groupBoxFiltrosHistorial.Controls.Add(this.lblFechaHistorial);
            this.groupBoxFiltrosHistorial.Controls.Add(this.dtpFechaHistorial);
            this.groupBoxFiltrosHistorial.Location = new System.Drawing.Point(20, 20);
            this.groupBoxFiltrosHistorial.Name = "groupBoxFiltrosHistorial";
            this.groupBoxFiltrosHistorial.Size = new System.Drawing.Size(1017, 108);
            this.groupBoxFiltrosHistorial.TabIndex = 0;
            this.groupBoxFiltrosHistorial.TabStop = false;
            this.groupBoxFiltrosHistorial.Text = "Filtros de Historial";
            // 
            // btnConsultarAsistencias
            // 
            this.btnConsultarAsistencias.Location = new System.Drawing.Point(23, 59);
            this.btnConsultarAsistencias.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarAsistencias.Name = "btnConsultarAsistencias";
            this.btnConsultarAsistencias.Size = new System.Drawing.Size(229, 37);
            this.btnConsultarAsistencias.TabIndex = 6;
            this.btnConsultarAsistencias.Text = "Consultar historial de asistencias";
            this.btnConsultarAsistencias.UseVisualStyleBackColor = true;
            this.btnConsultarAsistencias.Click += new System.EventHandler(this.btnConsultarAsistencias_Click);
            // 
            // lblFechaHistorial
            // 
            this.lblFechaHistorial.AutoSize = true;
            this.lblFechaHistorial.Location = new System.Drawing.Point(20, 30);
            this.lblFechaHistorial.Name = "lblFechaHistorial";
            this.lblFechaHistorial.Size = new System.Drawing.Size(48, 16);
            this.lblFechaHistorial.TabIndex = 0;
            this.lblFechaHistorial.Text = "Fecha:";
            // 
            // dtpFechaHistorial
            // 
            this.dtpFechaHistorial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHistorial.Location = new System.Drawing.Point(80, 28);
            this.dtpFechaHistorial.Name = "dtpFechaHistorial";
            this.dtpFechaHistorial.Size = new System.Drawing.Size(172, 22);
            this.dtpFechaHistorial.TabIndex = 1;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(20, 150);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.Size = new System.Drawing.Size(1024, 324);
            this.dgvHistorial.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHistorial);
            this.tabControl.Location = new System.Drawing.Point(22, 29);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1067, 517);
            this.tabControl.TabIndex = 8;
            // 
            // FrmConsultarHistorialA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 569);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmConsultarHistorialA";
            this.Text = "FrmConsultarHistorialA";
            this.tabHistorial.ResumeLayout(false);
            this.groupBoxFiltrosHistorial.ResumeLayout(false);
            this.groupBoxFiltrosHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.GroupBox groupBoxFiltrosHistorial;
        private System.Windows.Forms.Button btnConsultarAsistencias;
        private System.Windows.Forms.Label lblFechaHistorial;
        private System.Windows.Forms.DateTimePicker dtpFechaHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.TabControl tabControl;
    }
}