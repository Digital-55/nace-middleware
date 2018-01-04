namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ValoracionAspectosDiariosCursoMateria")]
    public partial class ValoracionAspectosDiariosCursoMateria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ValoracionAspectosDiariosCursoMateria()
        {
            NotaAspectosDiariosCursoMateria = new HashSet<NotaAspectosDiariosCursoMateria>();
        }

        [Key]
        public int IdValoracion { get; set; }

        public int IdAspecto { get; set; }

        public int IdLiteral { get; set; }

        public int Anyo { get; set; }

        public bool Estado { get; set; }

        public virtual AspectosDiariosCursoMateria AspectosDiariosCursoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAspectosDiariosCursoMateria> NotaAspectosDiariosCursoMateria { get; set; }
    }
}
