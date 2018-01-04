namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotaAspecto")]
    public partial class NotaAspecto
    {
        [Key]
        public int IdNotasAspecto { get; set; }

        public int IdAspecto { get; set; }

        public int IdAlumno { get; set; }

        public int IdEvaluacion { get; set; }

        public int? IdValoracionAspecto { get; set; }

        public double? Nota { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaNota { get; set; }

        [StringLength(50)]
        public string Actitud { get; set; }

        [StringLength(50)]
        public string Recomendacion { get; set; }

        public int IdNotaAlumno { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Aspectos Aspectos { get; set; }

        public virtual Evaluacion Evaluacion { get; set; }

        public virtual NotaAlumno NotaAlumno { get; set; }

        public virtual ValoracionAspecto ValoracionAspecto { get; set; }
    }
}
