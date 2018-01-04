namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DatosPendientesAprobacion_Alumno
    {
        public int ID { get; set; }

        public int IdAlumno { get; set; }

        public short? TipoDoc { get; set; }

        [StringLength(20)]
        public string DocIdentidad { get; set; }

        public DateTime? DocIdentidad_FechaSolicitudCambio { get; set; }

        public int? IdPaisContacto { get; set; }

        public DateTime? IdPaisContacto_FechaSolicitudCambio { get; set; }

        public int? IdProvinciaContacto { get; set; }

        public DateTime? IdProvinciaContacto_FechaSolicitudCambio { get; set; }

        [StringLength(100)]
        public string PoblacionContacto { get; set; }

        public DateTime? PoblacionContacto_FechaSolicitudCambio { get; set; }

        [StringLength(5)]
        public string CPContacto { get; set; }

        public DateTime? CPContacto_FechaSolicitudCambio { get; set; }

        [StringLength(200)]
        public string DireccionContacto { get; set; }

        public DateTime? DireccionContacto_FechaSolicitudCambio { get; set; }

        [StringLength(255)]
        public string EmailContacto { get; set; }

        public DateTime? EmailContacto_FechaSolicitudCambio { get; set; }

        [StringLength(20)]
        public string Tlf1 { get; set; }

        public DateTime? Tlf1_FechaSolicitudCambio { get; set; }

        [StringLength(20)]
        public string Tlf2 { get; set; }

        public DateTime? Tlf2_FechaSolicitudCambio { get; set; }

        public bool SolicitaAlumno { get; set; }

        public bool SolicitaFamiliar { get; set; }

        public bool? Procesado { get; set; }

        public DateTime? FechaProcesado { get; set; }

        public string UsuarioProcesadoCambio { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Pais Pais { get; set; }

        public virtual Provincia Provincia { get; set; }

        public virtual TipoDocIdentidad TipoDocIdentidad { get; set; }
    }
}
