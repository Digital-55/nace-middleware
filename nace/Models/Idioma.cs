namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Idioma")]
    public partial class Idioma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Idioma()
        {
            Alumno = new HashSet<Alumno>();
            Traducciones = new HashSet<Traducciones>();
            PlantillaCorreo = new HashSet<PlantillaCorreo>();
        }

        [Key]
        public short IdIdioma { get; set; }

        [Column("Idioma")]
        [Required]
        [StringLength(100)]
        public string Idioma1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Cultura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumno> Alumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Traducciones> Traducciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlantillaCorreo> PlantillaCorreo { get; set; }
    }
}
