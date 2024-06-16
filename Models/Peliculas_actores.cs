//------------------------------------------------------------------------------
// <written-by>
//     This code was written by David Cardenas.
//     © 2024 David Cardenas. All rights reserved.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </written-by>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations; // Namespace for data annotations

namespace API_MySql_ASP.NET.Models
{
    public class Peliculas_actores
    {
        [Key] // Specifies that peliculas_id is the primary key
        public int peliculas_id { get; set; } // Property for pelicula ID

        public int actores_id { get; set; } // Property for actor ID
    }
}