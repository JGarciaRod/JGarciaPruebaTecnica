using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Musica
    {
        public static ML.Result Add(ML.Disco disco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.JGarciaPruebaTecnicaEntities contex = new DL.JGarciaPruebaTecnicaEntities())
                {
                    var rowsAfected = contex.MusicaAdd(
                        disco.Titulo,
                        disco.Artista,
                        disco.GeneroMusical,
                        disco.Duracion,
                        disco.Año,
                        disco.Distribuidora,
                        disco.Ventas,
                        disco.Disponibilidad
                        );
                    if (rowsAfected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct= false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result Update(ML.Disco disco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.JGarciaPruebaTecnicaEntities context = new DL.JGarciaPruebaTecnicaEntities())
                {
                    var rowsAffecteed = context.MusicaUpdate(
                        disco.IdDisco,
                        disco.Titulo,
                        disco.Artista,
                        disco.GeneroMusical,
                        disco.Duracion,
                        disco.Año,
                        disco.Distribuidora,
                        disco.Ventas,
                        disco.Disponibilidad
                        );

                    if(rowsAffecteed > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result Dell(int IdDisco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.JGarciaPruebaTecnicaEntities contex = new DL.JGarciaPruebaTecnicaEntities())
                {
                    var rowAffected = contex.MusicaDelete(IdDisco);

                    if (rowAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.JGarciaPruebaTecnicaEntities context = new DL.JGarciaPruebaTecnicaEntities())
                {
                    var rowAffected = context.MusicaGetAll().ToList();


                    if (rowAffected != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var filas in rowAffected)
                        {
                            ML.Disco disco = new ML.Disco();

                            disco.Titulo = filas.Titulo;
                            disco.Artista = filas.Artista;
                            disco.GeneroMusical = filas.GeneroMusical;
                            disco.Duracion = filas.Duracion;
                            disco.Año = filas.Año;
                            disco.Distribuidora = filas.Distribuidora;
                            disco.Ventas = filas.Ventas.Value;
                            disco.Disponibilidad = filas.Disponobilidad.Value;

                            result.Objects.Add(disco);
                        }
                        result.Correct = true;
                    }
                }
            }
            catch( Exception ex )
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetById(int IdDisco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.JGarciaPruebaTecnicaEntities context = new DL.JGarciaPruebaTecnicaEntities())
                {
                    var rowAfsected = context.MusicaGetById(IdDisco).SingleOrDefault();

                    result.Objects = new List<object>();

                    if (rowAfsected != null)
                    {
                        ML.Disco disco = new ML.Disco();

                        disco.IdDisco = rowAfsected.IdDisco;
                        disco.Titulo = rowAfsected.Titulo;
                        disco.Artista = rowAfsected.Artista;
                        disco.GeneroMusical = rowAfsected.GeneroMusical;
                        disco.Duracion = rowAfsected.Duracion;
                        disco.Año = disco.Año;
                        disco.Distribuidora = rowAfsected.Distribuidora;
                        disco.Ventas = disco.Ventas;
                        disco.Disponibilidad = disco.Disponibilidad;

                        result.Object = disco;

                        result.Correct = true;
                    }
                }
            }
            catch( Exception ex )
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
