namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AlumnosDesubicados
    {
        [Key]
        public int IdAlumnosDesubicados { get; set; }

        public int IdAlumno { get; set; }

        public int IdCursoGrupoDesubicado { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual CursoGrupo CursoGrupo { get; set; }
    }
}
