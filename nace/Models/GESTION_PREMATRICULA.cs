namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GESTION_PREMATRICULA
    {
        [Key]
        public int IdPrematricula { get; set; }

        public int IdAlumno { get; set; }

        public int IdCurso { get; set; }

        [Required]
        [StringLength(4)]
        public string Anyo { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
