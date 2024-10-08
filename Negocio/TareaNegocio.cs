﻿using System;
using System.Collections.Generic;
using Entidades;
using Datos;

namespace Negocio
{
    public class TareaNegocio
    {
        public List<Tarea> Listar(string estadoFiltro)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Tarea> tareas = new List<Tarea>();

            string consulta = @"
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
                        Categorias C ON T.CategoriaId = C.CategoriaId
                    WHERE 
                        T.Estado = @EstadoFiltro";

            try
            {
                datos.Consulta(consulta);
                datos.SetearParametro("@EstadoFiltro", estadoFiltro);
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

        public List<Tarea> ListarActivas()
        {
            return Listar("Activo");
        }
        public List<Tarea> ListarInactivas()
        {
            return Listar("Inactivo");
        }

        public void Agregar(Tarea nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            {
                string consulta = "INSERT INTO Tareas (Nombre, Descripcion, FechaCreacion, Recordatorio, CategoriaId, Estado) VALUES (@Nom, @Desc, @FechaCre, @Rec, @CatId, @Est)";

                try
                {
                    datos.Consulta(consulta);
                    datos.SetearParametro("@Nom", nuevo.Nombre);
                    datos.SetearParametro("@Desc", nuevo.Descripcion);
                    datos.SetearParametro("@FechaCre", nuevo.FechaCreacion = DateTime.Now); 
                    datos.SetearParametro("@Rec", nuevo.FechaCreacion = DateTime.Now); 
                    datos.SetearParametro("@CatId", nuevo.Categoria.Id);
                    datos.SetearParametro("@Est", nuevo.Estado = "Activo");

                    datos.ejecutarConsulta(); 
                }
                catch (Exception ex)
                {
                    throw ex; 
                }
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.Consulta("delete from Tareas where TareaId = @Id");
                datos.SetearParametro("@id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarL(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.Consulta("UPDATE Tareas SET Estado = 'Inactivo' WHERE TareaId = @Id;");
                datos.SetearParametro("@Id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        
        public void Restaurar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.Consulta("UPDATE Tareas SET Estado = 'Activo' WHERE TareaId = @Id;");
                datos.SetearParametro("@Id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
