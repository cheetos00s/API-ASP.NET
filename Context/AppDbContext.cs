﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace API_MySql_ASP.NET.Context
{
    using Microsoft.EntityFrameworkCore;
    using API_MySql_ASP.NET.Models;

    /// <summary>
    /// Represents the application database context.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppDbContext"/> class.
        /// </summary>
        /// <param name="options">The options to be used by the DbContext.</param>
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the directors table.
        /// </summary>
        public DbSet<Directores> Directores { get; set; }

        /// <summary>
        /// Gets or sets the movies table.
        /// </summary>
        public DbSet<Peliculas> Peliculas { get; set; }

        /// <summary>
        /// Gets or sets the actors table.
        /// </summary>
        public DbSet<Actores> Actores { get; set; }

        /// <summary>
        /// Gets or sets the movies-actors relationships table.
        /// </summary>
        public DbSet<Peliculas_actores> PeliculasActores { get; set; }
    }
}