using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    internal class CategoriaNegocio
    {
        List<Categoria> categorias;
        public List<Categoria> listar()
        {
            Categoria categoria = new Categoria();  
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT Id,Nombre from Categorias";

            try
            {
                datos.Consulta(query);
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    categoria.Id = (int)datos.Lector["Id"];
                    categoria.Id = (int)datos.Lector["Nombre"];

                    categorias.Add(categoria);
                }

                datos.CerrarConexion();
                return categorias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
