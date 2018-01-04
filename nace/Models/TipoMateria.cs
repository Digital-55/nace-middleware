namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoMateria")]
    public partial class TipoMateria
    {
        [Key]
        public short IdTipoMateria { get; set; }

        public int IdLiteral { get; set; }

        public bool Estado { get; set; }
    }
}
