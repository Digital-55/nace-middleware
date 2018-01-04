namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Traducciones
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdLiteral { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IdIdioma { get; set; }

        [Required]
        [StringLength(255)]
        public string Literal { get; set; }

        [StringLength(50)]
        public string Abrev { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public virtual Idioma Idioma { get; set; }

        public virtual Literales Literales { get; set; }
    }
}
