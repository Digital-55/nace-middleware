namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LibrosCursoMateria")]
    public partial class LibrosCursoMateria
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdLibro { get; set; }

        [StringLength(1)]
        public string Grupo { get; set; }

        [StringLength(2559)]
        public string Observaciones { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCursoGrupoMateria { get; set; }

        public virtual CursoGrupoMateria CursoGrupoMateria { get; set; }

        public virtual Libros Libros { get; set; }
    }
}
