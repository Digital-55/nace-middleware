namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoPlantilla")]
    public partial class TipoPlantilla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoPlantilla()
        {
            PlantillaCorreo = new HashSet<PlantillaCorreo>();
        }

        [Key]
        public int IdTipoPlantilla { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlantillaCorreo> PlantillaCorreo { get; set; }
    }
}
