namespace Academix.vista
{
    partial class FrmNuevoVinculo
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
            this.cbApoderado = new System.Windows.Forms.ComboBox();
            this.cbEstudiante = new System.Windows.Forms.ComboBox();
            this.cbPrioridad = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParentesco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtVinculo = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.grpDatosPrincipales.SuspendLayout();
            this.SuspendLayout();
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
            this.grpDatosPrincipales.Controls.Add(this.label1);
            this.grpDatosPrincipales.Controls.Add(this.button1);
            this.grpDatosPrincipales.Controls.Add(this.btnInsertar);
            this.grpDatosPrincipales.Controls.Add(this.txtVinculo);
            this.grpDatosPrincipales.Controls.Add(this.lblNombres);
            this.grpDatosPrincipales.Location = new System.Drawing.Point(12, 12);
            this.grpDatosPrincipales.Name = "grpDatosPrincipales";
            this.grpDatosPrincipales.Size = new System.Drawing.Size(409, 283);
            this.grpDatosPrincipales.TabIndex = 8;
            this.grpDatosPrincipales.TabStop = false;
            this.grpDatosPrincipales.Text = "DATOS PRINCIPALES";
            // 
            // cbApoderado
            // 
            this.cbApoderado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApoderado.FormattingEnabled = true;
            this.cbApoderado.Location = new System.Drawing.Point(148, 89);
            this.cbApoderado.Name = "cbApoderado";
            this.cbApoderado.Size = new System.Drawing.Size(231, 24);
            this.cbApoderado.TabIndex = 30;
            // 
            // cbEstudiante
            // 
            this.cbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstudiante.FormattingEnabled = true;
            this.cbEstudiante.Location = new System.Drawing.Point(148, 60);
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
            this.cbPrioridad.Location = new System.Drawing.Point(147, 145);
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
            this.cbEstado.Location = new System.Drawing.Point(148, 173);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(231, 24);
            this.cbEstado.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Prioridad:";
            // 
            // txtParentesco
            // 
            this.txtParentesco.Location = new System.Drawing.Point(148, 118);
            this.txtParentesco.Name = "txtParentesco";
            this.txtParentesco.Size = new System.Drawing.Size(231, 22);
            this.txtParentesco.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Parentesco:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID Apoderado:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID Vinculo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancelar";
            this.button1.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnInsertar.Location = new System.Drawing.Point(146, 210);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(108, 37);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Registrar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtVinculo
            // 
            this.txtVinculo.Location = new System.Drawing.Point(148, 33);
            this.txtVinculo.Name = "txtVinculo";
            this.txtVinculo.Size = new System.Drawing.Size(231, 22);
            this.txtVinculo.TabIndex = 1;
            // 
            // lblNombres
            // 
            this.lblNombres.Location = new System.Drawing.Point(6, 61);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(100, 23);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "ID Estudiante:";
            // 
            // FrmNuevoVinculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 314);
            this.Controls.Add(this.grpDatosPrincipales);
            this.Name = "FrmNuevoVinculo";
            this.Text = "FrmNuevoVinculo";
            this.grpDatosPrincipales.ResumeLayout(false);
            this.grpDatosPrincipales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPrincipales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParentesco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPrioridad;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbApoderado;
        private System.Windows.Forms.ComboBox cbEstudiante;
        private System.Windows.Forms.TextBox txtVinculo;
    }
}