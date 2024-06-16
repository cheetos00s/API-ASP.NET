//------------------------------------------------------------------------------
// <written-by>
//     This code was written by David Cardenas.
//     © 2024 David Cardenas. All rights reserved.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </written-by>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Namespace for data annotations

namespace API_MySql_ASP.NET.Models
{
    public class Peliculas
    {
        [Key] // Specifies that pelicula_id is the primary key
        public int pelicula_id { get; set; } // Property for pelicula ID

        public required string titulo { get; set; } // Property for pelicula's title
        public DateTime fecha_estreno { get; set; } // Property for pelicula's release date
        public string genero { get; set; } // Property for pelicula's genre
        public DateTime fecha_registro { get; set; } // Property for pelicula's registration date

        public List<Directores> Directores { get; set; } // Navigation property to hold directors associated with the pelicula

    }
}
