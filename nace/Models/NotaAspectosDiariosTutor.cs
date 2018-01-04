namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotaAspectosDiariosTutor")]
    public partial class NotaAspectosDiariosTutor
    {
        [Key]
        public int IdNota { get; set; }

        public int IdAlumno { get; set; }

        public int IdCursoGrupo { get; set; }

        public DateTime Fecha { get; set; }

        public int? IdAspecto { get; set; }

        public int? IdValoracion { get; set; }

        public string Comentario { get; set; }

        public bool Visible { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual AspectosDiariosTutor AspectosDiariosTutor { get; set; }

        public virtual CursoGrupo CursoGrupo { get; set; }

        public virtual ValoracionAspectosDiariosTutor ValoracionAspectosDiariosTutor { get; set; }
    }
}
