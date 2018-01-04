namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LINKS_CURSOGRUPO
    {
        [Key]
        public int IdLink { get; set; }

        public int IdLiteral { get; set; }

        public int IdCursoGrupo { get; set; }

        [Required]
        public string URL { get; set; }

        public int? Orden { get; set; }

        public virtual CursoGrupo CursoGrupo { get; set; }

        public virtual Literales Literales { get; set; }
    }
}
