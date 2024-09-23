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
            dgvTareas.DataSource = negocio.Listar();
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
    }
}
