namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EquivalenciasTiposMaterias
    {
        [Key]
        public int IdEquivalenciaTipoMateria { get; set; }

        public int IdLiteral { get; set; }

        public short Nota { get; set; }

        public short IdNivel { get; set; }

        [Required]
        [StringLength(4)]
        public string Anyo { get; set; }

        public bool Estado { get; set; }

        public virtual Nivel Nivel { get; set; }
    }
}
