namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONFIGCORREO")]
    public partial class CONFIGCORREO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FROMCORREO { get; set; }

        [StringLength(50)]
        public string CC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string HOST { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PORT { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string USUARIOSMTP { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string PASSWORDSMTP { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool SSL { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool HTML { get; set; }
    }
}
