namespace Academix.vista
{
    partial class FrmNuevoCurso
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
            this.grpDatosPrincipales = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.lblApePaterno = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.grpDatosPrincipales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPrincipales
            // 
            this.grpDatosPrincipales.Controls.Add(this.label1);
            this.grpDatosPrincipales.Controls.Add(this.button1);
            this.grpDatosPrincipales.Controls.Add(this.btnInsertar);
            this.grpDatosPrincipales.Controls.Add(this.txtApePaterno);
            this.grpDatosPrincipales.Controls.Add(this.lblApePaterno);
            this.grpDatosPrincipales.Controls.Add(this.txtId);
            this.grpDatosPrincipales.Controls.Add(this.lblNombres);
            this.grpDatosPrincipales.Controls.Add(this.txtNombres);
            this.grpDatosPrincipales.Location = new System.Drawing.Point(26, 26);
            this.grpDatosPrincipales.Name = "grpDatosPrincipales";
            this.grpDatosPrincipales.Size = new System.Drawing.Size(443, 217);
            this.grpDatosPrincipales.TabIndex = 4;
            this.grpDatosPrincipales.TabStop = false;
            this.grpDatosPrincipales.Text = "DATOS PRINCIPALES";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID Curso:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancelar";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnInsertar.Location = new System.Drawing.Point(150, 145);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(108, 37);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Registrar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(150, 96);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(231, 22);
            this.txtApePaterno.TabIndex = 7;
            // 
            // lblApePaterno
            // 
            this.lblApePaterno.Location = new System.Drawing.Point(6, 96);
            this.lblApePaterno.Name = "lblApePaterno";
            this.lblApePaterno.Size = new System.Drawing.Size(123, 23);
            this.lblApePaterno.TabIndex = 6;
            this.lblApePaterno.Text = "Descripcion:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(231, 22);
            this.txtId.TabIndex = 1;
            // 
            // lblNombres
            // 
            this.lblNombres.Location = new System.Drawing.Point(6, 61);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(100, 23);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "Curso:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(148, 61);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(233, 22);
            this.txtNombres.TabIndex = 5;
            // 
            // FrmNuevoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 274);
            this.Controls.Add(this.grpDatosPrincipales);
            this.Name = "FrmNuevoCurso";
            this.Text = "FrmNuevoCurso";
            this.grpDatosPrincipales.ResumeLayout(false);
            this.grpDatosPrincipales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPrincipales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.Label lblApePaterno;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
    }
}