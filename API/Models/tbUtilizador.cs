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
    
    public partial class tbUtilizador
    {
        public int idUtilizador { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string nome { get; set; }
        public Nullable<System.Guid> UUID { get; set; }
        public System.DateTime dataCriado { get; set; }
    }
}
