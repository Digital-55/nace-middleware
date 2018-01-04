namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlumnoCursoGrupo")]
    public partial class AlumnoCursoGrupo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAlumno { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCursoGrupo { get; set; }

        public short Estado { get; set; }

        public DateTime FechaEstado { get; set; }

        [StringLength(10)]
        public string NotaFinal { get; set; }

        public bool? CursoPrincipal { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual CursoGrupo CursoGrupo { get; set; }
    }
}
