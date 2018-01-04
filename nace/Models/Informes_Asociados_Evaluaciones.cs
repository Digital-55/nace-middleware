namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Informes_Asociados_Evaluaciones
    {
        public int ID { get; set; }

        public int IdEvaluacion { get; set; }

        public int IdInforme { get; set; }
    }
}
