namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IconosValoracion")]
    public partial class IconosValoracion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IconosValoracion()
        {
            ValoracionAspecto = new HashSet<ValoracionAspecto>();
        }

        [Key]
        public int IdIcono { get; set; }

        [Required]
        public string NombreIcono { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValoracionAspecto> ValoracionAspecto { get; set; }
    }
}
