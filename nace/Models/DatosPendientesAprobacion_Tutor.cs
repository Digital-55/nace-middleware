namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DatosPendientesAprobacion_Tutor
    {
        public int ID { get; set; }

        public int IdTutor { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public DateTime? Email_FechaSolicitudCambio { get; set; }

        [StringLength(20)]
        public string Tlf1 { get; set; }

        public DateTime? Tlf1_FechaSolicitudCambio { get; set; }

        [StringLength(20)]
        public string Tlf2 { get; set; }

        public DateTime? Tlf2_FechaSolicitudCambio { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        public DateTime? FAX_FechaSolicitudCambio { get; set; }

        [StringLength(20)]
        public string SMS { get; set; }

        public DateTime? SMS_FechaSolicitudCambio { get; set; }

        [StringLength(20)]
        public string SMSX { get; set; }

        public DateTime? SMSX_FechaSolicitudCambio { get; set; }

        public int? IdPaisContacto { get; set; }

        public DateTime? IdPaisContacto_FechaSolicitudCambio { get; set; }

        public int? IdProvinciaContacto { get; set; }

        public DateTime? IdProvinciaContacto_FechaSolicitudCambio { get; set; }

        [StringLength(100)]
        public string PoblacionContacto { get; set; }

        public DateTime? PoblacionContacto_FechaSolicitudCambio { get; set; }

        [StringLength(5)]
        public string CP_Contacto { get; set; }

        public DateTime? CP_Contacto_FechaSolicitudCambio { get; set; }

        [StringLength(255)]
        public string Direccion_Contacto { get; set; }

        public DateTime? Direccion_Contacto_FechaSolicitudCambio { get; set; }

        public bool? Procesado { get; set; }

        public DateTime? FechaProcesado { get; set; }

        public string UsuarioProcesadoCambio { get; set; }

        public virtual Tutor Tutor { get; set; }
    }
}
