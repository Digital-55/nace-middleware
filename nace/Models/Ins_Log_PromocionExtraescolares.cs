namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Log_PromocionExtraescolares
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Anyo { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime FechaPromocion { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Usuario_Promocion { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Promocion_DefExtraescolares { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Promocion_Horarios { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Promocion_AsignacionProfesores { get; set; }
    }
}
