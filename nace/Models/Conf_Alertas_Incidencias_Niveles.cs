namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Conf_Alertas_Incidencias_Niveles
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdNivel { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Activar_Alertas_Ausencias { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Activar_Alertas_Retraso { get; set; }

        public string Texto_SMS_Retraso_ES { get; set; }

        public string Texto_SMS_Retraso_CA { get; set; }

        public string Texto_SMS_Retraso_EN { get; set; }

        public string Texto_SMS_Ausencia_ES { get; set; }

        public string Texto_SMS_Ausencia_CA { get; set; }

        public string Texto_SMS_Ausencia_EN { get; set; }
    }
}
