namespace Academix.vista
{
    partial class FrmNuevoRol
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.grpDatosPrincipales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPrincipales
            // 
            this.grpDatosPrincipales.Controls.Add(this.button2);
            this.grpDatosPrincipales.Controls.Add(this.label1);
            this.grpDatosPrincipales.Controls.Add(this.button1);
            this.grpDatosPrincipales.Controls.Add(this.txtId);
            this.grpDatosPrincipales.Controls.Add(this.lblNombres);
            this.grpDatosPrincipales.Controls.Add(this.txtNombres);
            this.grpDatosPrincipales.Location = new System.Drawing.Point(21, 21);
            this.grpDatosPrincipales.Name = "grpDatosPrincipales";
            this.grpDatosPrincipales.Size = new System.Drawing.Size(443, 175);
            this.grpDatosPrincipales.TabIndex = 6;
            this.grpDatosPrincipales.TabStop = false;
            this.grpDatosPrincipales.Text = "DATOS PRINCIPALES";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Location = new System.Drawing.Point(148, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 37);
            this.button2.TabIndex = 22;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID Rol:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancelar";
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
            this.lblNombres.Size = new System.Drawing.Size(136, 23);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "Nombre del rol:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(148, 61);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(233, 22);
            this.txtNombres.TabIndex = 5;
            // 
            // FrmNuevoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 212);
            this.Controls.Add(this.grpDatosPrincipales);
            this.Name = "FrmNuevoRol";
            this.Text = "FrmNuevoRol";
            this.grpDatosPrincipales.ResumeLayout(false);
            this.grpDatosPrincipales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPrincipales;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
    }
}