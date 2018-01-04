namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Inscripciones
    {
        public int ID { get; set; }

        public int IdAlumno { get; set; }

        public int IdActividadExtraescolar { get; set; }

        public int NumUnidades { get; set; }

        public DateTime FechaEfecto { get; set; }

        public bool Estado { get; set; }

        [Required]
        [StringLength(1)]
        public string EstadoInscripcion { get; set; }

        public DateTime FechaAlta { get; set; }

        public int TipoActividadSegunGestion { get; set; }

        public int IdSolicitudAlta { get; set; }

        public DateTime? FechaBaja { get; set; }

        public int? IdSolicitudBaja { get; set; }

        public DateTime? FechaEfectoBaja { get; set; }

        public int? IdHorario { get; set; }

        public bool? Modificada { get; set; }
    }
}
