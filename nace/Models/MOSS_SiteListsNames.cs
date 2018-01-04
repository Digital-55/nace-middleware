namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOSS_SiteListsNames
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MOSS_SiteListsNames()
        {
            MOSS_Permisos_SiteLists = new HashSet<MOSS_Permisos_SiteLists>();
        }

        [Key]
        public int IDLista { get; set; }

        [Required]
        [StringLength(255)]
        public string ListName { get; set; }

        public int? IdSite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOSS_Permisos_SiteLists> MOSS_Permisos_SiteLists { get; set; }

        public virtual MOSS_Site MOSS_Site { get; set; }
    }
}
