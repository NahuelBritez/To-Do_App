namespace Presentacion
{
    partial class frmPapelera
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
            this.dgvEliminadas = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnEliminarF = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminadas
            // 
            this.dgvEliminadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminadas.Location = new System.Drawing.Point(12, 12);
            this.dgvEliminadas.Name = "dgvEliminadas";
            this.dgvEliminadas.Size = new System.Drawing.Size(569, 150);
            this.dgvEliminadas.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(13, 169);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(175, 169);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnEliminarF
            // 
            this.btnEliminarF.Location = new System.Drawing.Point(256, 169);
            this.btnEliminarF.Name = "btnEliminarF";
            this.btnEliminarF.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarF.TabIndex = 1;
            this.btnEliminarF.Text = "Eliminar";
            this.btnEliminarF.UseVisualStyleBackColor = true;
            this.btnEliminarF.Click += new System.EventHandler(this.btnEliminarF_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(94, 169);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 1;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // frmPapelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 223);
            this.Controls.Add(this.btnEliminarF);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvEliminadas);
            this.Name = "frmPapelera";
            this.Text = "frmPapelera";
            this.Load += new System.EventHandler(this.frmPapelera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEliminadas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnEliminarF;
        private System.Windows.Forms.Button btnDetalle;
    }
}