namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlumnoCursoGrupoMteria")]
    public partial class AlumnoCursoGrupoMteria
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAlumno { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCursoGrupoMateria { get; set; }

        public bool Terminado { get; set; }

        [StringLength(255)]
        public string Observaciones { get; set; }

        public int? IdProfesorCalifica { get; set; }

        public bool Estado { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual CursoGrupoMateria CursoGrupoMateria { get; set; }
    }
}
