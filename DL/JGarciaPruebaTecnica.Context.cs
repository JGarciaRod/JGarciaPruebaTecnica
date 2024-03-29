﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class JGarciaPruebaTecnicaEntities : DbContext
    {
        public JGarciaPruebaTecnicaEntities()
            : base("name=JGarciaPruebaTecnicaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Musica> Musicas { get; set; }
    
        public virtual int MusicaAdd(string titulo, string artista, string generoMusical, string duracion, string año, string distribuidora, Nullable<int> ventas, Nullable<int> disponobilidad)
        {
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var artistaParameter = artista != null ?
                new ObjectParameter("Artista", artista) :
                new ObjectParameter("Artista", typeof(string));
    
            var generoMusicalParameter = generoMusical != null ?
                new ObjectParameter("GeneroMusical", generoMusical) :
                new ObjectParameter("GeneroMusical", typeof(string));
    
            var duracionParameter = duracion != null ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(string));
    
            var añoParameter = año != null ?
                new ObjectParameter("Año", año) :
                new ObjectParameter("Año", typeof(string));
    
            var distribuidoraParameter = distribuidora != null ?
                new ObjectParameter("Distribuidora", distribuidora) :
                new ObjectParameter("Distribuidora", typeof(string));
    
            var ventasParameter = ventas.HasValue ?
                new ObjectParameter("Ventas", ventas) :
                new ObjectParameter("Ventas", typeof(int));
    
            var disponobilidadParameter = disponobilidad.HasValue ?
                new ObjectParameter("Disponobilidad", disponobilidad) :
                new ObjectParameter("Disponobilidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MusicaAdd", tituloParameter, artistaParameter, generoMusicalParameter, duracionParameter, añoParameter, distribuidoraParameter, ventasParameter, disponobilidadParameter);
        }
    
        public virtual int MusicaDelete(Nullable<int> idDisco)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MusicaDelete", idDiscoParameter);
        }
    
        public virtual ObjectResult<MusicaGetAll_Result> MusicaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MusicaGetAll_Result>("MusicaGetAll");
        }
    
        public virtual ObjectResult<MusicaGetById_Result> MusicaGetById(Nullable<int> idDisco)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MusicaGetById_Result>("MusicaGetById", idDiscoParameter);
        }
    
        public virtual int MusicaUpdate(Nullable<int> idDisco, string titulo, string artista, string generoMusical, string duracion, string año, string distribuidora, Nullable<int> ventas, Nullable<int> disponobilidad)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var artistaParameter = artista != null ?
                new ObjectParameter("Artista", artista) :
                new ObjectParameter("Artista", typeof(string));
    
            var generoMusicalParameter = generoMusical != null ?
                new ObjectParameter("GeneroMusical", generoMusical) :
                new ObjectParameter("GeneroMusical", typeof(string));
    
            var duracionParameter = duracion != null ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(string));
    
            var añoParameter = año != null ?
                new ObjectParameter("Año", año) :
                new ObjectParameter("Año", typeof(string));
    
            var distribuidoraParameter = distribuidora != null ?
                new ObjectParameter("Distribuidora", distribuidora) :
                new ObjectParameter("Distribuidora", typeof(string));
    
            var ventasParameter = ventas.HasValue ?
                new ObjectParameter("Ventas", ventas) :
                new ObjectParameter("Ventas", typeof(int));
    
            var disponobilidadParameter = disponobilidad.HasValue ?
                new ObjectParameter("Disponobilidad", disponobilidad) :
                new ObjectParameter("Disponobilidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MusicaUpdate", idDiscoParameter, tituloParameter, artistaParameter, generoMusicalParameter, duracionParameter, añoParameter, distribuidoraParameter, ventasParameter, disponobilidadParameter);
        }
    }
}
