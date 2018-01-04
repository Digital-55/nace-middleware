namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CursoGrupo")]
    public partial class CursoGrupo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CursoGrupo()
        {
            AlumnoCursoGrupo = new HashSet<AlumnoCursoGrupo>();
            AlumnosDesubicados = new HashSet<AlumnosDesubicados>();
            AlumnosObservaciones = new HashSet<AlumnosObservaciones>();
            CursoGrupoMateria = new HashSet<CursoGrupoMateria>();
            LINKS_CURSOGRUPO = new HashSet<LINKS_CURSOGRUPO>();
            NotaAspectosDiariosTutor = new HashSet<NotaAspectosDiariosTutor>();
        }

        [Key]
        public int IdCursoGrupo { get; set; }

        public int IdLiteral { get; set; }

        public int IdCurso { get; set; }

        [Required]
        [StringLength(1)]
        public string Grupo { get; set; }

        [Required]
        [StringLength(4)]
        public string Anyo { get; set; }

        public int? IdResponsable { get; set; }

        public string Observaciones { get; set; }

        [StringLength(1)]
        public string NumFamDimoni { get; set; }

        public bool Estado { get; set; }

        public int? IdResponsable2 { get; set; }

        [StringLength(50)]
        public string CodCursoGrupo_Untis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoCursoGrupo> AlumnoCursoGrupo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnosDesubicados> AlumnosDesubicados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnosObservaciones> AlumnosObservaciones { get; set; }

        public virtual Curso Curso { get; set; }

        public virtual Profesor Profesor { get; set; }

        public virtual Profesor Profesor1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursoGrupoMateria> CursoGrupoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LINKS_CURSOGRUPO> LINKS_CURSOGRUPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAspectosDiariosTutor> NotaAspectosDiariosTutor { get; set; }
    }
}
