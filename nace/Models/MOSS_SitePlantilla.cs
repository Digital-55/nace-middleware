namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOSS_SitePlantilla
    {
        [Key]
        public int IdSitePlantilla { get; set; }

        public int IdSite { get; set; }

        [Required]
        public string NombrePlantilla { get; set; }

        public virtual MOSS_Site MOSS_Site { get; set; }
    }
}
