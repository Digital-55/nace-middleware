namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlantillaCorreo")]
    public partial class PlantillaCorreo
    {
        [Key]
        public int IdPlantilla { get; set; }

        public short IdIdioma { get; set; }

        public int IdTipoPlantilla { get; set; }

        [Required]
        [StringLength(100)]
        public string Asunto { get; set; }

        [Required]
        public string Encabezado { get; set; }

        [StringLength(100)]
        public string Usuario { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        public string PieCorreo { get; set; }

        public virtual Idioma Idioma { get; set; }

        public virtual TipoPlantilla TipoPlantilla { get; set; }
    }
}
