using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
             List<Categoria> categorias = new List<Categoria>(); 
            AccesoDatos datos = new AccesoDatos();
            string query = "SELECT CategoriaId,Nombre from Categorias";

            try
            {
                datos.Consulta(query);
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)datos.Lector["CategoriaId"];
                    categoria.Nombre = (string)datos.Lector["Nombre"];

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
