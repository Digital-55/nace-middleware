namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AspectosDiariosCursoMateria")]
    public partial class AspectosDiariosCursoMateria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspectosDiariosCursoMateria()
        {
            NotaAspectosDiariosCursoMateria = new HashSet<NotaAspectosDiariosCursoMateria>();
            ValoracionAspectosDiariosCursoMateria = new HashSet<ValoracionAspectosDiariosCursoMateria>();
        }

        [Key]
        public int IdAspecto { get; set; }

        public int IdCursoMateria { get; set; }

        public int IdLiteral { get; set; }

        public bool Estado { get; set; }

        public bool Visible { get; set; }

        public bool VisibleFamiliares { get; set; }

        public virtual CursoMateria CursoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAspectosDiariosCursoMateria> NotaAspectosDiariosCursoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValoracionAspectosDiariosCursoMateria> ValoracionAspectosDiariosCursoMateria { get; set; }
    }
}
