namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Evaluacion")]
    public partial class Evaluacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evaluacion()
        {
            AlumnosObservaciones = new HashSet<AlumnosObservaciones>();
            ConfigEvalResum = new HashSet<ConfigEvalResum>();
            NotaAlumno = new HashSet<NotaAlumno>();
            NotaAspecto = new HashSet<NotaAspecto>();
        }

        [Key]
        public int IdEvaluacion { get; set; }

        public short NumEvaluacion { get; set; }

        public short IdNivel { get; set; }

        public int? IdLiteral { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FInicio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FFin { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FInicioNotas { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FFinNotas { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FJunta { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FInicioRecup { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FFinRecup { get; set; }

        [Required]
        [StringLength(4)]
        public string Anyo { get; set; }

        public bool DocOficial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnosObservaciones> AlumnosObservaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfigEvalResum> ConfigEvalResum { get; set; }

        public virtual Literales Literales { get; set; }

        public virtual Nivel Nivel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAlumno> NotaAlumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAspecto> NotaAspecto { get; set; }
    }
}
