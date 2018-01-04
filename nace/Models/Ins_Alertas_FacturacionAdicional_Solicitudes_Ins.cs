namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Alertas_FacturacionAdicional_Solicitudes_Ins
    {
        public int ID { get; set; }

        public int IdAlumno { get; set; }

        public DateTime FechaCreacion { get; set; }

        [Required]
        public string UsuarioCreacion { get; set; }

        public int Porc_Facturar { get; set; }

        public int IdSolicitud { get; set; }

        public DateTime? FechaProcesa { get; set; }

        public string UsuarioProcesa { get; set; }

        public int EstadoAlerta { get; set; }

        public bool Estado { get; set; }

        public DateTime? FechaDelete { get; set; }

        public string UsuarioDelete { get; set; }
    }
}
