namespace Presentacion
{
    partial class frmPrincipal
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
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnEliminarL = new System.Windows.Forms.Button();
            this.btnPapelera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(223, 29);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(534, 252);
            this.dgvTareas.TabIndex = 0;
            this.dgvTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(225, 287);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(306, 287);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 1;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnEliminarL
            // 
            this.btnEliminarL.Location = new System.Drawing.Point(387, 287);
            this.btnEliminarL.Name = "btnEliminarL";
            this.btnEliminarL.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarL.TabIndex = 1;
            this.btnEliminarL.Text = "Eliminar";
            this.btnEliminarL.UseVisualStyleBackColor = true;
            this.btnEliminarL.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // btnPapelera
            // 
            this.btnPapelera.Location = new System.Drawing.Point(468, 287);
            this.btnPapelera.Name = "btnPapelera";
            this.btnPapelera.Size = new System.Drawing.Size(75, 23);
            this.btnPapelera.TabIndex = 2;
            this.btnPapelera.Text = "Papelera";
            this.btnPapelera.UseVisualStyleBackColor = true;
            this.btnPapelera.Click += new System.EventHandler(this.btnPapelera_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.btnPapelera);
            this.Controls.Add(this.btnEliminarL);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTareas);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnEliminarL;
        private System.Windows.Forms.Button btnPapelera;
    }
}

