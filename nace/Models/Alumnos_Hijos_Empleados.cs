namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Alumnos_Hijos_Empleados
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
        public string NIF { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Usuario { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime FechaCreacion { get; set; }
    }
}
