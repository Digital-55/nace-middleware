namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UNTIS_PRECARGA_CV
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string NUM_LECCION { get; set; }

        [StringLength(50)]
        public string HORAS_SEMANALES { get; set; }

        [StringLength(50)]
        public string HORAS_SEMANALES_GRUPO { get; set; }

        [StringLength(50)]
        public string HORAS_SEMANALES_PROFESOR { get; set; }

        [StringLength(50)]
        public string CODCURSOGRUPO_UNTIS { get; set; }

        [StringLength(50)]
        public string NUMEMPLEADO { get; set; }

        [StringLength(50)]
        public string CODMATERIA_NACE { get; set; }

        public int? IDMATERIA { get; set; }

        public int? IDCURSOGRUPOMATERIA { get; set; }

        public string NOMBRE_MATERIA { get; set; }

        public int? IDPROFESOR { get; set; }

        public string NOMBRE_PROFESOR { get; set; }

        public int? IDCURSOGRUPO { get; set; }

        public string NOMBRE_CURSOGRUPO { get; set; }
    }
}
