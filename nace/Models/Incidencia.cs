namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Incidencia")]
    public partial class Incidencia
    {
        [Key]
        public int IdIncidencia { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public int IdAlumno { get; set; }

        public int? IdHorario { get; set; }

        public short? IdTipoIncidencia { get; set; }

        public bool? Justificada { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Horario Horario { get; set; }

        public virtual TipoIncidencia TipoIncidencia { get; set; }
    }
}
