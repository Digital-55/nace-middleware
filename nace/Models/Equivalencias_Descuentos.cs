namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Equivalencias_Descuentos
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CodDescuento { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string Seccion { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Descripcion { get; set; }
    }
}
