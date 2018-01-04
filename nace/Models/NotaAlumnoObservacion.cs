namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotaAlumnoObservacion")]
    public partial class NotaAlumnoObservacion
    {
        [Key]
        public int IdNotaAlumnoObservacion { get; set; }

        public int IdNotaAlumno { get; set; }

        public DateTime FechaObserv { get; set; }

        public int? IdObservGenerica { get; set; }

        public string Observaciones { get; set; }

        public short? IdTipoObservacion { get; set; }

        public virtual NotaAlumno NotaAlumno { get; set; }

        public virtual ObservGenerica ObservGenerica { get; set; }
    }
}
