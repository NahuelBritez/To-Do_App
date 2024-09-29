using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public List<Tarea> lista;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        private void Cargar()
        {
            TareaNegocio negocio = new TareaNegocio();
            dgvTareas.DataSource = negocio.ListarActivas();
            dgvTareas.Columns["Id"].Visible = false;
            dgvTareas.Columns["FechaCreacion"].Visible = false;
            dgvTareas.Columns["FechaCompletado"].Visible = false;
            dgvTareas.Columns["Estado"].Visible = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarTarea frmAgregar = new frmAgregarTarea();
            frmAgregar.ShowDialog();
            Cargar();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Tarea seleccionado;

            try
            {
                if (dgvTareas.CurrentRow != null)
                {
                    seleccionado = (Tarea)dgvTareas.CurrentRow.DataBoundItem;
                    frmDetalle frmDetalle = new frmDetalle(seleccionado);
                    frmDetalle.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione un articulo para verlo en detalle.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Tarea seleccionado = new Tarea();
            TareaNegocio negocio = new TareaNegocio();

            try
            {
                if (dgvTareas.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Tarea)dgvTareas.CurrentRow.DataBoundItem;
                        negocio.Eliminar(seleccionado.Id);
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un articulo para eliminar");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Tarea seleccionado = new Tarea();
            TareaNegocio negocio = new TareaNegocio();

            try
            {
                if (dgvTareas.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Tarea)dgvTareas.CurrentRow.DataBoundItem;
                        negocio.EliminarL(seleccionado.Id);
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un articulo para eliminar");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgvTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPapelera_Click(object sender, EventArgs e)
        {
            frmPapelera frmPapelera = new frmPapelera();
            frmPapelera.ShowDialog();
            Cargar();
        }
    }
}
