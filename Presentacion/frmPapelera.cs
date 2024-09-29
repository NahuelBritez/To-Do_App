using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPapelera : Form
    {
        public frmPapelera()
        {
            InitializeComponent();
        }

        private void frmPapelera_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            TareaNegocio negocio = new TareaNegocio();
            dgvEliminadas.DataSource = negocio.ListarInactivas();
            dgvEliminadas.Columns["Id"].Visible = false;
            dgvEliminadas.Columns["FechaCreacion"].Visible = false;
            dgvEliminadas.Columns["FechaCompletado"].Visible = false;
            dgvEliminadas.Columns["Estado"].Visible = false;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Tarea seleccionado;

            try
            {
                if (dgvEliminadas.CurrentRow != null)
                {
                    seleccionado = (Tarea)dgvEliminadas.CurrentRow.DataBoundItem;
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Tarea seleccionado = new Tarea();
            TareaNegocio negocio = new TareaNegocio();

            try
            {
                if (dgvEliminadas.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿De verdad querés restaurarlo?", "Restaurando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Tarea)dgvEliminadas.CurrentRow.DataBoundItem;
                        negocio.Restaurar(seleccionado.Id);
                        MessageBox.Show("Tarea restaurada.");
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un articulo para restaurar");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminarF_Click(object sender, EventArgs e)
        {
            Tarea seleccionado = new Tarea();
            TareaNegocio negocio = new TareaNegocio();

            try
            {
                if (dgvEliminadas.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo definitivamente?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Tarea)dgvEliminadas.CurrentRow.DataBoundItem;
                        negocio.Eliminar(seleccionado.Id);
                        MessageBox.Show("Tarea eliminada.");
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un articulo para restaurar");
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}