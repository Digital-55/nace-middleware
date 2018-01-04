namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlumnoTutor")]
    public partial class AlumnoTutor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAlumno { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTutor { get; set; }

        public int Orden { get; set; }

        [StringLength(100)]
        public string Relac_Familiar { get; set; }

        public bool? VerFacturas { get; set; }

        public bool RecibeDocs { get; set; }

        public bool? EditaDatosHijo { get; set; }

        public bool? GestionarExtraescolares { get; set; }

        public bool? RecibeSMS { get; set; }

        public bool? Visibilidad { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Tutor Tutor { get; set; }
    }
}
