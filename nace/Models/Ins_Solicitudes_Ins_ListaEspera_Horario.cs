namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Solicitudes_Ins_ListaEspera_Horario
    {
        public int ID { get; set; }

        public int IdAlumno { get; set; }

        public int IdActividadExtraescolar { get; set; }

        public int NumUnidades { get; set; }

        public int TipoActividadSegunGestion { get; set; }

        public DateTime FechaEfecto { get; set; }

        public DateTime FechaCreacion { get; set; }

        [Required]
        public string UsuarioCreacion { get; set; }

        public int? IdHorario { get; set; }

        public bool Estado { get; set; }

        public DateTime? FechaBorrado { get; set; }

        public string UsuarioBorrado { get; set; }

        public bool? ProcesadoCoordinador { get; set; }

        public string UsuarioProcesadoCoordinador { get; set; }

        public DateTime? FechaProcesadoCoordinador { get; set; }

        public string EstadoFlujo { get; set; }

        public int? MotivoRechazoSolicitud { get; set; }
    }
}
