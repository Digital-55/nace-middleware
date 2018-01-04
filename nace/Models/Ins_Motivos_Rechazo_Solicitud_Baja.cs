namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Motivos_Rechazo_Solicitud_Baja
    {
        public int ID { get; set; }

        public string Literal_ES { get; set; }

        [Required]
        public string Literal_CA { get; set; }

        [Required]
        public string Literal_EN { get; set; }

        public int Orden { get; set; }
    }
}
