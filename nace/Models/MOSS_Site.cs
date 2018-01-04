namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOSS_Site
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MOSS_Site()
        {
            MOSS_PaginasRole = new HashSet<MOSS_PaginasRole>();
            MOSS_Permisos_SiteLists = new HashSet<MOSS_Permisos_SiteLists>();
            MOSS_SiteListsNames = new HashSet<MOSS_SiteListsNames>();
            MOSS_SitePlantilla = new HashSet<MOSS_SitePlantilla>();
        }

        [Key]
        public int IdSite { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOSS_PaginasRole> MOSS_PaginasRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOSS_Permisos_SiteLists> MOSS_Permisos_SiteLists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOSS_SiteListsNames> MOSS_SiteListsNames { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOSS_SitePlantilla> MOSS_SitePlantilla { get; set; }
    }
}
