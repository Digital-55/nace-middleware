namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotaAspectosDiariosCursoMateria")]
    public partial class NotaAspectosDiariosCursoMateria
    {
        [Key]
        public int IdNota { get; set; }

        public int IdAlumno { get; set; }

        public int? IdCursoGrupoMateria { get; set; }

        public DateTime Fecha { get; set; }

        public int? IdAspecto { get; set; }

        public int? IdValoracion { get; set; }

        public string Comentario { get; set; }

        public bool Visible { get; set; }

        public bool? VisibleFamiliares { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual AspectosDiariosCursoMateria AspectosDiariosCursoMateria { get; set; }

        public virtual CursoGrupoMateria CursoGrupoMateria { get; set; }

        public virtual ValoracionAspectosDiariosCursoMateria ValoracionAspectosDiariosCursoMateria { get; set; }
    }
}
