namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Tabla_Estados_Flujo_ListaEspera
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(2)]
        public string Codigo { get; set; }

        [Required]
        public string Literal_ES { get; set; }

        [Required]
        public string Literal_CA { get; set; }

        [Required]
        public string Literal_EN { get; set; }

        [Required]
        public string Literal_Fam_ES { get; set; }

        [Required]
        public string Literal_Fam_CA { get; set; }

        [Required]
        public string Literal_Fam_EN { get; set; }

        public int Orden { get; set; }

        public bool DescuentaPlaza { get; set; }
    }
}
