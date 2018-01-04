namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AspectosDiariosTutor")]
    public partial class AspectosDiariosTutor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspectosDiariosTutor()
        {
            NotaAspectosDiariosTutor = new HashSet<NotaAspectosDiariosTutor>();
            ValoracionAspectosDiariosTutor = new HashSet<ValoracionAspectosDiariosTutor>();
        }

        [Key]
        public int IdAspecto { get; set; }

        public int IdCurso { get; set; }

        public int IdLiteral { get; set; }

        public bool Estado { get; set; }

        public bool Visible { get; set; }

        public virtual Curso Curso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAspectosDiariosTutor> NotaAspectosDiariosTutor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValoracionAspectosDiariosTutor> ValoracionAspectosDiariosTutor { get; set; }
    }
}
