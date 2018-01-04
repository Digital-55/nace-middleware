namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Equivalencias_Act_NP
    {
        [Key]
        [StringLength(20)]
        public string CodArticulo { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(8)]
        public string Seccion { get; set; }

        [Required]
        [StringLength(11)]
        public string CentroCoste { get; set; }
    }
}
