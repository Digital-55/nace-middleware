namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Curso")]
    public partial class Curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curso()
        {
            AspectosDiariosTutor = new HashSet<AspectosDiariosTutor>();
            Curso1 = new HashSet<Curso>();
            CursoGrupo = new HashSet<CursoGrupo>();
            CursoMateria = new HashSet<CursoMateria>();
            GESTION_PREMATRICULA = new HashSet<GESTION_PREMATRICULA>();
        }

        [Key]
        public int IdCurso { get; set; }

        public short IdCiclo { get; set; }

        public int IdLiteral { get; set; }

        [StringLength(10)]
        public string CodCurso { get; set; }

        public int? IdCursoSiguiente { get; set; }

        [StringLength(1)]
        public string NumFamDimoni { get; set; }

        public bool Estado { get; set; }

        public int? CODIGO_SAVIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspectosDiariosTutor> AspectosDiariosTutor { get; set; }

        public virtual Ciclo Ciclo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Curso> Curso1 { get; set; }

        public virtual Curso Curso2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursoGrupo> CursoGrupo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursoMateria> CursoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GESTION_PREMATRICULA> GESTION_PREMATRICULA { get; set; }
    }
}
