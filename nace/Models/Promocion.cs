namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Promocion")]
    public partial class Promocion
    {
        [Key]
        public int IdPromocion { get; set; }

        public int? IdAlumno { get; set; }

        public int? IdNivel { get; set; }

        public int? IdCiclo { get; set; }

        public int? IdCursoActual { get; set; }

        public int? IdCursoPromocion { get; set; }

        [StringLength(1)]
        public string Grupo { get; set; }

        public bool? CursoPrincipal { get; set; }

        [StringLength(4)]
        public string Anyo { get; set; }
    }
}
