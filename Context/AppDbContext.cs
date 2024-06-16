//------------------------------------------------------------------------------
// <written-by>
//     This code was written by David Cardenas.
//     © 2024 David Cardenas. All rights reserved.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </written-by>
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