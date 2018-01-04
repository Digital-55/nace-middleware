namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_TipoActividadSegunGestion
    {
        public int ID { get; set; }

        [Required]
        public string Literal_ES { get; set; }

        [Required]
        public string Literal_EN { get; set; }

        [Required]
        public string Literal_CA { get; set; }

        public int Orden { get; set; }

        public string Pagina { get; set; }
    }
}
