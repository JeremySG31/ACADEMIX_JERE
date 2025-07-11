namespace Academix.vista
{
    partial class FrmEliminarVinculo
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.grpInformacionAdicional = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.grpInformacionAdicional.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Location = new System.Drawing.Point(12, 85);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 37);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(268, 85);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(108, 37);
            this.btCancelar.TabIndex = 43;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // grpInformacionAdicional
            // 
            this.grpInformacionAdicional.Controls.Add(this.lblRol);
            this.grpInformacionAdicional.Controls.Add(this.cbId);
            this.grpInformacionAdicional.Location = new System.Drawing.Point(12, 12);
            this.grpInformacionAdicional.Name = "grpInformacionAdicional";
            this.grpInformacionAdicional.Size = new System.Drawing.Size(364, 52);
            this.grpInformacionAdicional.TabIndex = 42;
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
            // cbId
            // 
            this.cbId.Location = new System.Drawing.Point(158, 17);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(200, 24);
            this.cbId.TabIndex = 1;
            // 
            // FrmEliminarVinculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 156);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.grpInformacionAdicional);
            this.Name = "FrmEliminarVinculo";
            this.Text = "FrmEliminarVinculo";
            this.grpInformacionAdicional.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox grpInformacionAdicional;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cbId;
    }
}