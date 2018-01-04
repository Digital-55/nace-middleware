namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProfesorCursoGrupoMateria")]
    public partial class ProfesorCursoGrupoMateria
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCursoGrupoMateria { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdProfesor { get; set; }

        [StringLength(255)]
        public string Observaciones { get; set; }

        public bool FirmaActas { get; set; }

        public bool Evalua { get; set; }

        public virtual CursoGrupoMateria CursoGrupoMateria { get; set; }

        public virtual Profesor Profesor { get; set; }
    }
}
