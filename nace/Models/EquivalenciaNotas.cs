namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EquivalenciaNotas
    {
        [Key]
        public short IdEquivalenciaNotas { get; set; }

        public double NumeroMin { get; set; }

        public double NumeroMax { get; set; }

        public int IdLiteral { get; set; }

        public short IdNivel { get; set; }

        [Required]
        [StringLength(4)]
        public string Anyo { get; set; }

        public virtual Literales Literales { get; set; }

        public virtual Nivel Nivel { get; set; }
    }
}
