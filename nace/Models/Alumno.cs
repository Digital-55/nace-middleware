namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Alumno")]
    public partial class Alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumno()
        {
            Act_NP_Alumno = new HashSet<Act_NP_Alumno>();
            Act_PE_Alumno = new HashSet<Act_PE_Alumno>();
            AlumnoBanco = new HashSet<AlumnoBanco>();
            AlumnoCursoGrupo = new HashSet<AlumnoCursoGrupo>();
            AlumnoCursoGrupoMteria = new HashSet<AlumnoCursoGrupoMteria>();
            Alumnos_Recibidos_Traspaso = new HashSet<Alumnos_Recibidos_Traspaso>();
            AlumnosDesubicados = new HashSet<AlumnosDesubicados>();
            AlumnosObservaciones = new HashSet<AlumnosObservaciones>();
            AlumnoTutor = new HashSet<AlumnoTutor>();
            DatosPendientesAprobacion_Alumno = new HashSet<DatosPendientesAprobacion_Alumno>();
            GESTION_PREMATRICULA = new HashSet<GESTION_PREMATRICULA>();
            Incidencia = new HashSet<Incidencia>();
            Justificaciones_Ausencias_Alumnos = new HashSet<Justificaciones_Ausencias_Alumnos>();
            NotaAlumno = new HashSet<NotaAlumno>();
            NotaAspecto = new HashSet<NotaAspecto>();
            NotaAspectosDiariosCursoMateria = new HashSet<NotaAspectosDiariosCursoMateria>();
            NotaAspectosDiariosTutor = new HashSet<NotaAspectosDiariosTutor>();
            Registro_Pasar_Lista = new HashSet<Registro_Pasar_Lista>();
        }

        [Key]
        public int IdAlumno { get; set; }

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

        [Required]
        [StringLength(20)]
        public string CodMatricula { get; set; }

        public DateTime? FechaNacim { get; set; }

        public int? NIA { get; set; }

        public string NHA { get; set; }

        public int? NumExpte { get; set; }

        public string DatosMedicos { get; set; }

        [StringLength(20)]
        public string CIP { get; set; }

        public int? IdPais { get; set; }

        [StringLength(1)]
        public string Sexo { get; set; }

        public short? IdTipoDocIdentidad { get; set; }

        [StringLength(20)]
        public string DocIdentidad { get; set; }

        [StringLength(20)]
        public string NSS { get; set; }

        public int? NumHermanos { get; set; }

        public int? PosicHermanos { get; set; }

        public int? Estado { get; set; }

        public DateTime? FechaEstado { get; set; }

        [StringLength(20)]
        public string Tlf1 { get; set; }

        [StringLength(20)]
        public string Tlf2 { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public int? IdProvincia { get; set; }

        [StringLength(100)]
        public string Poblacion { get; set; }

        [StringLength(5)]
        public string CP { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [StringLength(100)]
        public string DocOrigen { get; set; }

        [Column(TypeName = "image")]
        public byte[] Foto { get; set; }

        public string Observaciones { get; set; }

        [Required]
        [StringLength(20)]
        public string NScta { get; set; }

        [StringLength(4)]
        public string FPago { get; set; }

        [StringLength(50)]
        public string Canal { get; set; }

        [StringLength(50)]
        public string PrimerCurso { get; set; }

        public int? IdPaisContacto { get; set; }

        public short? IdIdioma { get; set; }

        public string LNacimiento { get; set; }

        public int? ProvNacimiento { get; set; }

        public int? PaisNacimiento { get; set; }

        public bool? AutorizacionWeb { get; set; }

        public string Medicamentos { get; set; }

        public string Intolerancias { get; set; }

        public string Alergias { get; set; }

        public string Enfermedades { get; set; }

        public int? Lateralidad { get; set; }

        public string Vacunas { get; set; }

        public decimal? DESCUENTO_ESCOLARIDAD { get; set; }

        public decimal? DESCUENTO_COMEDOR { get; set; }

        public byte[] Adjunto { get; set; }

        [StringLength(10)]
        public string TipoAdjunto { get; set; }

        [StringLength(200)]
        public string NombreAdjunto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Act_NP_Alumno> Act_NP_Alumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Act_PE_Alumno> Act_PE_Alumno { get; set; }

        public virtual Idioma Idioma { get; set; }

        public virtual Pais Pais { get; set; }

        public virtual Provincia Provincia { get; set; }

        public virtual TipoDocIdentidad TipoDocIdentidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoBanco> AlumnoBanco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoCursoGrupo> AlumnoCursoGrupo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoCursoGrupoMteria> AlumnoCursoGrupoMteria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumnos_Recibidos_Traspaso> Alumnos_Recibidos_Traspaso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnosDesubicados> AlumnosDesubicados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnosObservaciones> AlumnosObservaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoTutor> AlumnoTutor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosPendientesAprobacion_Alumno> DatosPendientesAprobacion_Alumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GESTION_PREMATRICULA> GESTION_PREMATRICULA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incidencia> Incidencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Justificaciones_Ausencias_Alumnos> Justificaciones_Ausencias_Alumnos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAlumno> NotaAlumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAspecto> NotaAspecto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAspectosDiariosCursoMateria> NotaAspectosDiariosCursoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAspectosDiariosTutor> NotaAspectosDiariosTutor { get; set; }

        public virtual Pais Pais1 { get; set; }

        public virtual Pais Pais2 { get; set; }

        public virtual Provincia Provincia1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro_Pasar_Lista> Registro_Pasar_Lista { get; set; }

        public virtual Tipo_Lateralidad Tipo_Lateralidad { get; set; }
    }
}
