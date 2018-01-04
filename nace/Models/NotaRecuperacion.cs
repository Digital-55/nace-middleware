namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotaRecuperacion")]
    public partial class NotaRecuperacion
    {
        [Key]
        public int IdNotaRecuperacion { get; set; }

        public int IdNotaAlumno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaNota { get; set; }

        public double Nota { get; set; }

        public virtual NotaAlumno NotaAlumno { get; set; }
    }
}
