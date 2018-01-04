namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParamInformeConf")]
    public partial class ParamInformeConf
    {
        [Key]
        public int IdParam { get; set; }

        public short IdNivel { get; set; }

        public int IdIdioma { get; set; }

        public bool VisibleCalificacion { get; set; }

        public bool VisibleActitud { get; set; }

        public bool VisibleIncidencias { get; set; }

        public bool VisibleObservMateria { get; set; }

        public bool VisibleObservTutor { get; set; }

        public bool VisibleLeyendaValoracion { get; set; }

        public bool VisibleMedidas { get; set; }

        public bool? VisibleNotasEval { get; set; }

        public bool? VisibleNotasAspecto { get; set; }
    }
}
