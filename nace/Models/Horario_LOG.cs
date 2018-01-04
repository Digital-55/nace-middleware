namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Horario_LOG
    {
        [Key]
        public int IdHorario_LOG { get; set; }

        public int? IdHorario { get; set; }

        public int? IdProfesor { get; set; }

        public int? IdCursoGrupoMateria { get; set; }

        public short? IdDiaSemana { get; set; }

        public DateTime? HoraInicio { get; set; }

        public DateTime? HoraFin { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(255)]
        public string Actividad { get; set; }

        public string Observaciones { get; set; }

        public int? IdTipoHorario { get; set; }

        public bool Estado { get; set; }

        public int? TipoRRHH { get; set; }

        public DateTime? FDesde { get; set; }

        public DateTime? FHasta { get; set; }

        public bool? Bloqueado { get; set; }

        public bool? Procesado { get; set; }

        public bool? new_registro { get; set; }

        public string Nombre_Materia { get; set; }

        public string Nombre_Profesor { get; set; }

        public DateTime? FechaProceso { get; set; }

        public string Nombre_TipoRRHH { get; set; }

        public string Nombre_CursoGrupo { get; set; }

        public bool? VIENE_UNTIS { get; set; }
    }
}
