namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LiteralInfResumEval")]
    public partial class LiteralInfResumEval
    {
        [Key]
        public int IdLiteralInfResumEval { get; set; }

        public int IdIdioma { get; set; }

        public string CabeceraPrincipal { get; set; }

        public string NombreColegio { get; set; }

        public string CabeceraSeccion { get; set; }

        public string CabeceraTutor { get; set; }

        public string CabeceraMatricula { get; set; }

        public string CabeceraAlumno { get; set; }

        public string CabeceraEvaluacion { get; set; }

        public string CabeceraMedia { get; set; }

        public string CabeceraSuspensos { get; set; }

        public string CabeceraAsistencia { get; set; }
    }
}
