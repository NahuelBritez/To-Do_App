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
    public partial class frmAgregarTarea : Form
    {
        private Tarea tarea = new Tarea();
        public frmAgregarTarea()
        {
            InitializeComponent();
        }

        private void frmAgregarTarea_Load(object sender, EventArgs e)
        {
            dtpRecordatorio.MinDate = DateTime.Now;
            CargarCbo();

        }

        public void CargarCbo()
        {
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {
                cboCategoria.DataSource = categoria.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Nombre";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TareaNegocio negocio = new TareaNegocio();

            try
            {
                tarea.Nombre = txtNombre.Text;
                tarea.Descripcion = rtxtDescripcion.Text;
                tarea.Recordatorio = dtpRecordatorio.Value;
                tarea.Categoria = (Categoria)cboCategoria.SelectedItem;
                negocio.Agregar(tarea);
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria frmAgregarCateg = new frmAgregarCategoria();
            frmAgregarCateg.ShowDialog();
            CargarCbo();
        }
    }
}
