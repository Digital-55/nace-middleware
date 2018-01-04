namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnioActual")]
    public partial class AnioActual
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Anio { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FechaInicioCurso { get; set; }

        public DateTime? FechaFinCurso { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }
    }
}
