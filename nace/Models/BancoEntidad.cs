namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BancoEntidad")]
    public partial class BancoEntidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BancoEntidad()
        {
            Banco = new HashSet<Banco>();
        }

        [Key]
        [StringLength(4)]
        public string IdEntidad { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Tipo_Banco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Banco> Banco { get; set; }
    }
}
