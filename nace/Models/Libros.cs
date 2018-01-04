namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Libros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Libros()
        {
            LibrosCursoMateria = new HashSet<LibrosCursoMateria>();
        }

        [Key]
        public int IdLibro { get; set; }

        [Required]
        [StringLength(255)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(10)]
        public string Editorial { get; set; }

        [StringLength(255)]
        public string Autor { get; set; }

        public int? Anyo { get; set; }

        [Column(TypeName = "image")]
        public byte[] FotoPortada { get; set; }

        [StringLength(50)]
        public string ISBN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LibrosCursoMateria> LibrosCursoMateria { get; set; }
    }
}
