namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Materia")]
    public partial class Materia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materia()
        {
            CursoGrupoMateria = new HashSet<CursoGrupoMateria>();
            CursoMateria = new HashSet<CursoMateria>();
            ObservGenerica = new HashSet<ObservGenerica>();
        }

        [Key]
        public int IdMateria { get; set; }

        public int IdLiteral { get; set; }

        [StringLength(10)]
        public string CodMateria { get; set; }

        public DateTime? FechaAlta { get; set; }

        public short? Estado { get; set; }

        public DateTime? FechaEstado { get; set; }

        [StringLength(50)]
        public string CODMATERIA_NACE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursoGrupoMateria> CursoGrupoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursoMateria> CursoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObservGenerica> ObservGenerica { get; set; }
    }
}
