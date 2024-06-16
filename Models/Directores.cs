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
    public class Directores
    {
        [Key] // Specifies that director_id is the primary key
        public int director_id { get; set; } // Property for director ID

        public required string nombre { get; set; } // Property for director's name
        public DateTime fecha_nacimiento { get; set; } // Property for director's date of birth

    }
}