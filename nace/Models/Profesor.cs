namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Profesor")]
    public partial class Profesor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profesor()
        {
            CursoGrupo = new HashSet<CursoGrupo>();
            CursoGrupo1 = new HashSet<CursoGrupo>();
            Horario = new HashSet<Horario>();
            ProfesorCursoGrupoMateria = new HashSet<ProfesorCursoGrupoMateria>();
        }

        [Key]
        public int IdProfesor { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido1 { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido2 { get; set; }

        public DateTime FechaAlta { get; set; }

        public DateTime? FechaNacim { get; set; }

        public int? IdPais { get; set; }

        [StringLength(1)]
        public string Sexo { get; set; }

        public short IdTipoDocIdentidad { get; set; }

        [Required]
        [StringLength(20)]
        public string DocIdentidad { get; set; }

        [StringLength(20)]
        public string NSS { get; set; }

        [StringLength(20)]
        public string Tlf1 { get; set; }

        [StringLength(20)]
        public string Tlf2 { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public int IdProvincia { get; set; }

        [Required]
        [StringLength(100)]
        public string Poblacion { get; set; }

        [Required]
        [StringLength(5)]
        public string CP { get; set; }

        [Required]
        [StringLength(255)]
        public string Direccion { get; set; }

        [Column(TypeName = "image")]
        public byte[] Foto { get; set; }

        public int? NumColegiado { get; set; }

        public DateTime? FechaCuerpo { get; set; }

        public string Observaciones { get; set; }

        public short? Estado { get; set; }

        public DateTime? FechaEstado { get; set; }

        public decimal? NUM_HORAS_CONTRATO { get; set; }

        public decimal? PORC_OCUPACION { get; set; }

        public string Tipo_Empleado { get; set; }

        public string Puesto_Trabajo { get; set; }

        public decimal? Horas_Extraescolares { get; set; }

        public string NUMEMPLEADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursoGrupo> CursoGrupo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursoGrupo> CursoGrupo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horario> Horario { get; set; }

        public virtual Pais Pais { get; set; }

        public virtual Provincia Provincia { get; set; }

        public virtual TipoDocIdentidad TipoDocIdentidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfesorCursoGrupoMateria> ProfesorCursoGrupoMateria { get; set; }
    }
}
