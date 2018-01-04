namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigResumEval")]
    public partial class ConfigResumEval
    {
        [Key]
        public int IdConfigResumEval { get; set; }

        public bool ActivarAspecto { get; set; }

        public bool Horizontal { get; set; }

        public short IdNivel { get; set; }

        [Required]
        [StringLength(4)]
        public string Anyo { get; set; }

        public bool Calificacion { get; set; }

        public bool Actitud { get; set; }

        public bool MedidasEducativas { get; set; }

        public bool Media { get; set; }

        public bool NSuspensos { get; set; }

        public bool Faltas { get; set; }

        public bool CalificacionAspecto { get; set; }

        public virtual Nivel Nivel { get; set; }
    }
}
