namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Justificaciones_Ausencias_Alumnos
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAlumno { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime FechaJustifica { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Usuario { get; set; }

        public virtual Alumno Alumno { get; set; }
    }
}
