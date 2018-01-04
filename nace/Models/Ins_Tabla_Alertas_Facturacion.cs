namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Tabla_Alertas_Facturacion
    {
        public int ID { get; set; }

        public int DiaMinimo { get; set; }

        public int DiaMaximo { get; set; }

        public int Porc_Facturar { get; set; }

        [Required]
        public string Desc_ES { get; set; }

        [Required]
        public string Desc_CA { get; set; }

        [Required]
        public string Desc_EN { get; set; }
    }
}
