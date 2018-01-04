namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Tabla_Modulos_Minimos
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string Codigo_Modulo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string CodigoUnidadMinima { get; set; }

        [Key]
        [Column(Order = 3)]
        public string NombreUnidadMinima { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Orden { get; set; }
    }
}
