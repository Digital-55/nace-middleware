namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log_Mod_NotasAlumno
    {
        public int ID { get; set; }

        public string ACCION { get; set; }

        public string Usuario_Realiza { get; set; }

        public string Nombre_Usuario_Realiza { get; set; }

        public DateTime? Fecha_Accion { get; set; }

        public int? IdNotaAlumno { get; set; }

        public int? IdAlumno { get; set; }

        public int? IdEvaluacion { get; set; }

        public double? Nota { get; set; }

        public DateTime? FechaNota { get; set; }

        public bool? Cerrada { get; set; }

        [StringLength(50)]
        public string Actitud { get; set; }

        [StringLength(50)]
        public string Medidas { get; set; }

        public double? Nota_Old { get; set; }

        public DateTime? FechaNota_Old { get; set; }

        public bool? Cerrada_Old { get; set; }

        [StringLength(50)]
        public string Actitud_Old { get; set; }

        [StringLength(50)]
        public string Medidas_Old { get; set; }
    }
}
