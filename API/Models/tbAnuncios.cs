//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbAnuncios
    {
        public int idAnuncio { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public System.DateTime dataCriado { get; set; }
        public int idUtilizador { get; set; }
        public bool publicado { get; set; }
    }
}