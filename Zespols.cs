//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PingPong7
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zespols
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zespols()
        {
            this.Tabelas = new HashSet<Tabelas>();
            this.Terminarzs = new HashSet<Terminarzs>();
            this.Zawodniks = new HashSet<Zawodniks>();
        }
    
        public string TeamName { get; set; }
        public string Klub { get; set; }
        public string Ulica { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tabelas> Tabelas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terminarzs> Terminarzs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zawodniks> Zawodniks { get; set; }
    }
}
