namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Act_PE_Alumno
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAlumno { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCursoGrupoMateria { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal Unidades { get; set; }

        public bool? Descuento { get; set; }

        public int? Porc_Descuento { get; set; }

        [StringLength(10)]
        public string CodDescuento { get; set; }

        public decimal? Documento { get; set; }

        public bool? Anticipo { get; set; }

        public bool? NOENVIAR { get; set; }

        public bool? ModuloInscripcion { get; set; }

        public virtual Alumno Alumno { get; set; }
    }
}
