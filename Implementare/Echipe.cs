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
    
    public partial class Echipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Echipe()
        {
            this.EchipeStudents = new HashSet<EchipeStudent>();
            this.EvenimentSportivEchipes = new HashSet<EvenimentSportivEchipe>();
            this.EvenimentSportivEchipes1 = new HashSet<EvenimentSportivEchipe>();
        }
    
        public int IdEchipe { get; set; }
        public string nume { get; set; }
        public int scor { get; set; }
        public Nullable<int> IDSport { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EchipeStudent> EchipeStudents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvenimentSportivEchipe> EvenimentSportivEchipes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvenimentSportivEchipe> EvenimentSportivEchipes1 { get; set; }
        public virtual Sporturi Sporturi { get; set; }
    }
}
