namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Codigos_Ind_Part
    {
        public int ID { get; set; }

        [Required]
        [StringLength(2)]
        public string Codigo { get; set; }

        [Required]
        public string Descripcion_ES { get; set; }

        [Required]
        public string Descripcion_CA { get; set; }

        [Required]
        public string Descripcion_EN { get; set; }
    }
}
