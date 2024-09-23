using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class frmAgregarCategoria : Form
    {
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptarC_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria categoria = new Categoria();

            try
            {
                categoria.Nombre = txtNombre.Text;
                negocio.Agregar(categoria);
                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
