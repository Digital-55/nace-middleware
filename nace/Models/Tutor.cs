namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tutor")]
    public partial class Tutor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tutor()
        {
            AlumnoTutor = new HashSet<AlumnoTutor>();
            DatosPendientesAprobacion_Tutor = new HashSet<DatosPendientesAprobacion_Tutor>();
            Log_Registro_Pasar_Lista_Familiares = new HashSet<Log_Registro_Pasar_Lista_Familiares>();
        }

        [Key]
        public int IdTutor { get; set; }

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

        [Required]
        [StringLength(100)]
        public string Tratamiento { get; set; }

        [StringLength(1)]
        public string Sexo { get; set; }

        [Column(TypeName = "image")]
        public byte[] Foto { get; set; }

        public short? IdTipoDocIdentidad { get; set; }

        [StringLength(100)]
        public string DocIdentidad { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public int IdProvincia { get; set; }

        [Required]
        [StringLength(100)]
        public string Poblacion { get; set; }

        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(5)]
        public string CP { get; set; }

        [Required]
        [StringLength(20)]
        public string Tlf1 { get; set; }

        [StringLength(20)]
        public string Tlf2 { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        [StringLength(20)]
        public string SMS { get; set; }

        [StringLength(20)]
        public string SMSX { get; set; }

        public string Observaciones { get; set; }

        public string Formacion { get; set; }

        public string PuestoTrabajo { get; set; }

        public string Empresa { get; set; }

        public string TLF_COMUNICADOS_SMS { get; set; }

        public int? PaisDocIdentidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoTutor> AlumnoTutor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosPendientesAprobacion_Tutor> DatosPendientesAprobacion_Tutor { get; set; }

        public virtual Provincia Provincia { get; set; }

        public virtual TipoDocIdentidad TipoDocIdentidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log_Registro_Pasar_Lista_Familiares> Log_Registro_Pasar_Lista_Familiares { get; set; }
    }
}
