namespace Presentacion
{
    partial class frmAgregarCategoria
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblACategoria = new System.Windows.Forms.Label();
            this.btnAceptarC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblACategoria
            // 
            this.lblACategoria.AutoSize = true;
            this.lblACategoria.Location = new System.Drawing.Point(12, 27);
            this.lblACategoria.Name = "lblACategoria";
            this.lblACategoria.Size = new System.Drawing.Size(55, 13);
            this.lblACategoria.TabIndex = 1;
            this.lblACategoria.Text = "Categoria:";
            // 
            // btnAceptarC
            // 
            this.btnAceptarC.Location = new System.Drawing.Point(232, 22);
            this.btnAceptarC.Name = "btnAceptarC";
            this.btnAceptarC.Size = new System.Drawing.Size(52, 23);
            this.btnAceptarC.TabIndex = 2;
            this.btnAceptarC.Text = "Aceptar";
            this.btnAceptarC.UseVisualStyleBackColor = true;
            this.btnAceptarC.Click += new System.EventHandler(this.btnAceptarC_Click);
            // 
            // frmAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 71);
            this.Controls.Add(this.btnAceptarC);
            this.Controls.Add(this.lblACategoria);
            this.Controls.Add(this.txtNombre);
            this.MaximumSize = new System.Drawing.Size(310, 110);
            this.MinimumSize = new System.Drawing.Size(310, 110);
            this.Name = "frmAgregarCategoria";
            this.Text = "frmAgregarCategoria";
            this.Load += new System.EventHandler(this.frmAgregarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblACategoria;
        private System.Windows.Forms.Button btnAceptarC;
    }
}