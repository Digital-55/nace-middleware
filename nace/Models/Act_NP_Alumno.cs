namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Act_NP_Alumno
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAlumno { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CodArticulo { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal Unidades { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime FechaActividad { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Enviado { get; set; }

        public int? Paquete { get; set; }

        public DateTime? FechaEnvio { get; set; }

        public bool? Historico { get; set; }

        public virtual Alumno Alumno { get; set; }
    }
}
