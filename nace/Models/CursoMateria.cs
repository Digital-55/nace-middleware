namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CursoMateria")]
    public partial class CursoMateria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CursoMateria()
        {
            Aspectos = new HashSet<Aspectos>();
            AspectosDiariosCursoMateria = new HashSet<AspectosDiariosCursoMateria>();
        }

        [Key]
        public int IdCursoMateria { get; set; }

        public int IdMateria { get; set; }

        public int IdCurso { get; set; }

        public int Anyo { get; set; }

        [StringLength(6)]
        public string CodMateria { get; set; }

        public bool Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aspectos> Aspectos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspectosDiariosCursoMateria> AspectosDiariosCursoMateria { get; set; }

        public virtual Curso Curso { get; set; }

        public virtual Materia Materia { get; set; }
    }
}
