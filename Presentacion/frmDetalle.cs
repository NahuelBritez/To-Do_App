using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class frmDetalle : Form
    {
        public Tarea tarea1 = null;
        public frmDetalle()
        {
            InitializeComponent();
        }        
        public frmDetalle(Tarea tarea)
        {
            InitializeComponent();
            this.tarea1 = tarea;
            this.ActiveControl = btnCerrar;
            Text = tarea.Nombre;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {

            lblNombre.Text = tarea1.Nombre;
            lblCreacion.Text = "\tCreado el: " + tarea1.FechaCreacion.ToString();
            rtxtDescripcion.Text = tarea1.Descripcion;
            lblCategoria.Text = "Categoria: " + tarea1.Categoria.ToString();
            lblRecordatorio.Text = tarea1.Recordatorio != null ? "Recordatorio establecido para el dia: " + tarea1.Recordatorio.ToString() : "";
            lblEstado.Text = "Estado: " + tarea1.Estado;
            lblCompletado.Text = tarea1.FechaCompletado != null ? tarea1.FechaCompletado.ToString() : ""; 
        }
    }
}
