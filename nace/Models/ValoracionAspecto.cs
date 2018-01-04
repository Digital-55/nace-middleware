namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ValoracionAspecto")]
    public partial class ValoracionAspecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ValoracionAspecto()
        {
            NotaAlumno = new HashSet<NotaAlumno>();
            NotaAspecto = new HashSet<NotaAspecto>();
        }

        [Key]
        public int IdValoracionAspecto { get; set; }

        public int IdLiteral { get; set; }

        public short IdNivel { get; set; }

        [Required]
        [StringLength(4)]
        public string Anyo { get; set; }

        public int? IdIcono { get; set; }

        public virtual IconosValoracion IconosValoracion { get; set; }

        public virtual Literales Literales { get; set; }

        public virtual Nivel Nivel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAlumno> NotaAlumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAspecto> NotaAspecto { get; set; }
    }
}
