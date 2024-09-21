using System;
using System.Collections.Generic;
using Entidades;
using Datos;

namespace Negocio
{
    public class TareaNegocio
    {
        public List<Tarea> Listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Tarea> tareas = new List<Tarea>();

            string query = @"
                SELECT 
                    T.TareaId AS IdTarea, 
                    T.Nombre AS NombreTarea, 
                    T.Descripcion AS Descripcion, 
                    T.FechaCreacion, 
                    T.Recordatorio AS FechaRecordatorio, 
                    T.FechaCompletado, 
                    C.Nombre AS Categoria, 
                    T.Estado
                FROM 
                    Tareas T
                JOIN 
                    Categorias C ON T.CategoriaId = C.CategoriaId";

            try
            {
                datos.Consulta(query);
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Tarea aux = new Tarea
                    {
                        Id = (int)datos.Lector["IdTarea"],
                        Nombre = (string)datos.Lector["NombreTarea"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        FechaCreacion = (DateTime)datos.Lector["FechaCreacion"],
                        Recordatorio = datos.Lector["FechaRecordatorio"] != DBNull.Value
                            ? (DateTime?)datos.Lector["FechaRecordatorio"] 
                            : null,
                        FechaCompletado = datos.Lector["FechaCompletado"] != DBNull.Value
                            ? (DateTime?)datos.Lector["FechaCompletado"] 
                            : null,
                        Categoria = new Categoria
                        {
                            Nombre = (string)datos.Lector["Categoria"]
                        },
                        Estado = (string)datos.Lector["Estado"]
                    };

                    tareas.Add(aux);
                }

                datos.CerrarConexion();
                return tareas;
            }
            catch (Exception ex)
            {
                datos.CerrarConexion();
                throw ex;
            }
        }
    }
}
