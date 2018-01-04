namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_TarifasExtraescolares
    {
        public int ID { get; set; }

        public int IdActividad { get; set; }

        public int NumUnidades { get; set; }

        [Required]
        public string ArticuloDimoni { get; set; }
    }
}
