namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOSS_RolesMOSS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MOSS_RolesMOSS()
        {
            MOSS_PaginasRole = new HashSet<MOSS_PaginasRole>();
            MOSS_Permisos_SiteLists = new HashSet<MOSS_Permisos_SiteLists>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdRole { get; set; }

        [Required]
        public string NombreRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOSS_PaginasRole> MOSS_PaginasRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOSS_Permisos_SiteLists> MOSS_Permisos_SiteLists { get; set; }
    }
}
