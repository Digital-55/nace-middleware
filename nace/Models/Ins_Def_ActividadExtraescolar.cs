namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Def_ActividadExtraescolar
    {
        public int ID { get; set; }

        [Required]
        public string NombreActividad_ES { get; set; }

        [Required]
        public string NombreActividad_EN { get; set; }

        [Required]
        public string NombreActividad_CA { get; set; }

        [Required]
        public string Descripcion_ES { get; set; }

        [Required]
        public string Descripcion_EN { get; set; }

        [Required]
        public string Descripcion_CA { get; set; }

        public bool Visible { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaInicioInscripcion { get; set; }

        public DateTime FechaFinInscripcion { get; set; }

        public int Anyo { get; set; }

        public int TipoActividadSegunGestion { get; set; }

        public int NumUnidadesMinimasContratar { get; set; }

        public int NumUnidadesMaximasContratar { get; set; }

        [Required]
        [StringLength(2)]
        public string TipoGestionModulos { get; set; }

        [Required]
        [StringLength(3)]
        public string ModuloMinimo { get; set; }

        public int? IdCursoGrupoMateriaCAV { get; set; }

        public string Seccion { get; set; }

        public string CentroCoste { get; set; }

        public bool? PermiteDescuentos { get; set; }

        public string FamiliaActividad { get; set; }

        [StringLength(2)]
        public string Codigo_Ind_Col { get; set; }

        public int? NumPlazasActividad { get; set; }
    }
}
