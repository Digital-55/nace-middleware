namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Tabla_Estados_Inscripcion
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string Codigo { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Literal_ES { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Literal_CA { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Literal_EN { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Orden { get; set; }
    }
}
