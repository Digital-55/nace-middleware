namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Alumnos_Recibidos_Traspaso
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
        public bool PendienteRevisar { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string Anyo { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Fecha_Traspaso { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Estado { get; set; }

        public virtual Alumno Alumno { get; set; }
    }
}
