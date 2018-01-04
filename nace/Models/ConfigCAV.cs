namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigCAV")]
    public partial class ConfigCAV
    {
        [Key]
        [Column(Order = 0)]
        public string ID_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        public string VALUE_KEY { get; set; }

        public string Comentario { get; set; }
    }
}
