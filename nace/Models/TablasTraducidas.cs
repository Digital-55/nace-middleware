namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TablasTraducidas
    {
        [Key]
        public int IdTabla { get; set; }

        [Required]
        public string NombreTabla { get; set; }
    }
}
