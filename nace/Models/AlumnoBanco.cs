namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlumnoBanco")]
    public partial class AlumnoBanco
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAlumno { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdBanco { get; set; }

        public bool? Habitual { get; set; }

        public DateTime? FECHAMANDATO { get; set; }

        [StringLength(35)]
        public string REFERENCIA { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Banco Banco { get; set; }
    }
}
