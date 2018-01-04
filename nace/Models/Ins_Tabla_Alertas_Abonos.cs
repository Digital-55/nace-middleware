namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Tabla_Alertas_Abonos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiaMinimo { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiaMaximo { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Porc_Facturar { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Desc_ES { get; set; }

        [Key]
        [Column(Order = 5)]
        public string Desc_CA { get; set; }

        [Key]
        [Column(Order = 6)]
        public string Desc_EN { get; set; }
    }
}
