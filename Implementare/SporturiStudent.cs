//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TemaABD
{
    using System;
    using System.Collections.Generic;
    
    public partial class SporturiStudent
    {
        public int IdSporturiStudent { get; set; }
        public Nullable<int> IDSport { get; set; }
        public Nullable<int> IDStudent { get; set; }
        public int scor { get; set; }
    
        public virtual Sporturi Sporturi { get; set; }
        public virtual Studenti Studenti { get; set; }
    }
}
