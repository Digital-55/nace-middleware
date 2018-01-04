namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoDocIdentidad")]
    public partial class TipoDocIdentidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoDocIdentidad()
        {
            Alumno = new HashSet<Alumno>();
            DatosPendientesAprobacion_Alumno = new HashSet<DatosPendientesAprobacion_Alumno>();
            Profesor = new HashSet<Profesor>();
            Tutor = new HashSet<Tutor>();
        }

        [Key]
        public short IdTipoDocIdentidad { get; set; }

        [Column("TipoDocIdentidad")]
        [Required]
        [StringLength(100)]
        public string TipoDocIdentidad1 { get; set; }

        public int? TipoDocIdentidad_DNI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumno> Alumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosPendientesAprobacion_Alumno> DatosPendientesAprobacion_Alumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Profesor> Profesor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tutor> Tutor { get; set; }
    }
}
