namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Banco")]
    public partial class Banco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Banco()
        {
            AlumnoBanco = new HashSet<AlumnoBanco>();
        }

        [Key]
        public int IdBanco { get; set; }

        [Required]
        [StringLength(4)]
        public string IdEntidad { get; set; }

        [Required]
        [StringLength(4)]
        public string Oficina { get; set; }

        [Required]
        [StringLength(2)]
        public string DC { get; set; }

        [Required]
        [StringLength(10)]
        public string NumCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Titular { get; set; }

        [Required]
        [StringLength(20)]
        public string NIF { get; set; }

        [Required]
        [StringLength(200)]
        public string DireccionTit { get; set; }

        [Required]
        [StringLength(5)]
        public string CPTit { get; set; }

        public int IdProvinciaTit { get; set; }

        [Required]
        [StringLength(100)]
        public string PoblacionTit { get; set; }

        [StringLength(50)]
        public string IBAN { get; set; }

        public string Observaciones { get; set; }

        public int? PaisCCC { get; set; }

        public int? PaisDocIdentidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoBanco> AlumnoBanco { get; set; }

        public virtual BancoEntidad BancoEntidad { get; set; }

        public virtual Provincia Provincia { get; set; }
    }
}
