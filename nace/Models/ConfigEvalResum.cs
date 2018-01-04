namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigEvalResum")]
    public partial class ConfigEvalResum
    {
        [Key]
        public int IdConfigEvalResum { get; set; }

        public int IdEvaluacion { get; set; }

        public short IdNivel { get; set; }

        [Required]
        [StringLength(4)]
        public string Anyo { get; set; }

        public virtual Evaluacion Evaluacion { get; set; }

        public virtual Nivel Nivel { get; set; }
    }
}
