namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigColorResum")]
    public partial class ConfigColorResum
    {
        [Key]
        public int IdConfigColorResum { get; set; }

        public int IdNivel { get; set; }

        [Required]
        [StringLength(4)]
        public string Anyo { get; set; }

        [Required]
        public string Suspenso { get; set; }

        [Required]
        public string Recuperado { get; set; }

        [Required]
        public string Cabecera { get; set; }

        [Required]
        public string Subcabecera { get; set; }
    }
}
