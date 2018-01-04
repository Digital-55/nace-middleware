namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Formatos_Boletines
    {
        [Key]
        public int IdInforme { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Informe { get; set; }
    }
}
