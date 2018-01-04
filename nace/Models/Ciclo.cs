namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ciclo")]
    public partial class Ciclo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ciclo()
        {
            Curso = new HashSet<Curso>();
        }

        [Key]
        public short IdCiclo { get; set; }

        public short IdNivel { get; set; }

        public int IdLiteral { get; set; }

        public bool Estado { get; set; }

        public virtual Nivel Nivel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Curso> Curso { get; set; }
    }
}
