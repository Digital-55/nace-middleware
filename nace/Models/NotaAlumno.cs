namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotaAlumno")]
    public partial class NotaAlumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NotaAlumno()
        {
            NotaAlumnoObservacion = new HashSet<NotaAlumnoObservacion>();
            NotaAspecto = new HashSet<NotaAspecto>();
            NotaRecuperacion = new HashSet<NotaRecuperacion>();
        }

        [Key]
        public int IdNotaAlumno { get; set; }

        public int IdAlumno { get; set; }

        public int IdCursoGrupoMateria { get; set; }

        public int IdEvaluacion { get; set; }

        public double? Nota { get; set; }

        public DateTime FechaNota { get; set; }

        public bool Cerrada { get; set; }

        [StringLength(50)]
        public string Actitud { get; set; }

        [StringLength(50)]
        public string Medidas { get; set; }

        [StringLength(255)]
        public string Recomendacion { get; set; }

        public int? IdValoracionAspecto { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual CursoGrupoMateria CursoGrupoMateria { get; set; }

        public virtual Evaluacion Evaluacion { get; set; }

        public virtual ValoracionAspecto ValoracionAspecto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAlumnoObservacion> NotaAlumnoObservacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAspecto> NotaAspecto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaRecuperacion> NotaRecuperacion { get; set; }
    }
}
