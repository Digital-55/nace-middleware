namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CursoGrupoMateria")]
    public partial class CursoGrupoMateria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CursoGrupoMateria()
        {
            AlumnoCursoGrupoMteria = new HashSet<AlumnoCursoGrupoMteria>();
            Horario = new HashSet<Horario>();
            LibrosCursoMateria = new HashSet<LibrosCursoMateria>();
            NotaAlumno = new HashSet<NotaAlumno>();
            NotaAspectosDiariosCursoMateria = new HashSet<NotaAspectosDiariosCursoMateria>();
            ProfesorCursoGrupoMateria = new HashSet<ProfesorCursoGrupoMateria>();
            Registro_Pasar_Lista = new HashSet<Registro_Pasar_Lista>();
        }

        [Key]
        public int IdCursoGrupoMateria { get; set; }

        public int IdCursoGrupo { get; set; }

        public int IdMateria { get; set; }

        public short? IdTipoMateria { get; set; }

        [StringLength(255)]
        public string Observaciones { get; set; }

        public bool ocultarBoletin { get; set; }

        [StringLength(10)]
        public string CodMateria { get; set; }

        public bool Estado { get; set; }

        public int? Orden { get; set; }

        public bool Reglada { get; set; }

        public int? TipoRRHH { get; set; }

        public bool? Bloqueado { get; set; }

        public bool? EsBI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoCursoGrupoMteria> AlumnoCursoGrupoMteria { get; set; }

        public virtual CursoGrupo CursoGrupo { get; set; }

        public virtual Materia Materia { get; set; }

        public virtual Tipo_RRHH Tipo_RRHH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horario> Horario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LibrosCursoMateria> LibrosCursoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAlumno> NotaAlumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAspectosDiariosCursoMateria> NotaAspectosDiariosCursoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfesorCursoGrupoMateria> ProfesorCursoGrupoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro_Pasar_Lista> Registro_Pasar_Lista { get; set; }
    }
}
