namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AlumnosObservaciones
    {
        [Key]
        public int IdAlumnoObservacion { get; set; }

        public int IdCursoGrupo { get; set; }

        public int IdAlumno { get; set; }

        public int IdEvaluacion { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaObservacion { get; set; }

        public int? IdObservGenerica { get; set; }

        public string Observaciones { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual CursoGrupo CursoGrupo { get; set; }

        public virtual Evaluacion Evaluacion { get; set; }

        public virtual ObservGenerica ObservGenerica { get; set; }
    }
}
