namespace Academix.vista
{
    partial class FrmPanelProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPanelProfesor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialAsistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.iNICIOToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("asistenciaToolStripMenuItem.Image")));
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            this.asistenciaToolStripMenuItem.Click += new System.EventHandler(this.asistenciaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialAsistenciasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // historialAsistenciasToolStripMenuItem
            // 
            this.historialAsistenciasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historialAsistenciasToolStripMenuItem.Image")));
            this.historialAsistenciasToolStripMenuItem.Name = "historialAsistenciasToolStripMenuItem";
            this.historialAsistenciasToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.historialAsistenciasToolStripMenuItem.Text = "Historial asistencias";
            this.historialAsistenciasToolStripMenuItem.Click += new System.EventHandler(this.historialAsistenciasToolStripMenuItem_Click);
            // 
            // FrmPanelProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(869, 516);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(887, 563);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(887, 563);
            this.Name = "FrmPanelProfesor";
            this.Text = "FrmPanelProfesor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialAsistenciasToolStripMenuItem;
    }
}