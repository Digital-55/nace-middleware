namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOSS_PaginasRole
    {
        [Key]
        public int IdPaginasRole { get; set; }

        [Required]
        public string Pagina { get; set; }

        public int IdRole { get; set; }

        [Required]
        public string Permiso { get; set; }

        public int? IdSite { get; set; }

        public virtual MOSS_RolesMOSS MOSS_RolesMOSS { get; set; }

        public virtual MOSS_Site MOSS_Site { get; set; }
    }
}
