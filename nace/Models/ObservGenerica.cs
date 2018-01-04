namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ObservGenerica")]
    public partial class ObservGenerica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ObservGenerica()
        {
            AlumnosObservaciones = new HashSet<AlumnosObservaciones>();
            NotaAlumnoObservacion = new HashSet<NotaAlumnoObservacion>();
        }

        [Key]
        public int IdObservGenerica { get; set; }

        public int IdLiteral { get; set; }

        public short? IdNivel { get; set; }

        public int? IdMateria { get; set; }

        public bool? Tutor { get; set; }

        public bool Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnosObservaciones> AlumnosObservaciones { get; set; }

        public virtual Materia Materia { get; set; }

        public virtual Nivel Nivel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAlumnoObservacion> NotaAlumnoObservacion { get; set; }
    }
}
