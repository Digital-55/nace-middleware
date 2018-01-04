namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Tabla_Pantalla_GestionInscripciones
    {
        public int ID { get; set; }

        [Required]
        public string Literal_ES { get; set; }

        [Required]
        public string Literal_CA { get; set; }

        [Required]
        public string Literal_EN { get; set; }

        public int Orden { get; set; }

        public bool Gestion { get; set; }

        public bool Listados { get; set; }

        public bool VisibleResponsablesExtraescolares { get; set; }

        public bool VisibleResponsablesFacturacion { get; set; }

        [Required]
        public string URL_Pagina { get; set; }

        public bool MantenimientoExt { get; set; }

        public bool GestionSolicitudes { get; set; }

        public bool? ActivoLink { get; set; }

        public bool? InscripcionesAlumno { get; set; }
    }
}
