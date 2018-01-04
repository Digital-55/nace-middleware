namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LiteralesInformes
    {
        [Key]
        public int IdLiteralInforme { get; set; }

        public int IdNivel { get; set; }

        public int IdIdioma { get; set; }

        [StringLength(250)]
        public string CabeceraPrincipal { get; set; }

        [StringLength(250)]
        public string CabeceraAlumno { get; set; }

        [StringLength(250)]
        public string CabeceraGrupo { get; set; }

        [StringLength(250)]
        public string CabeceraNEvaluacion { get; set; }

        [StringLength(250)]
        public string CabeceraFecha { get; set; }

        [StringLength(250)]
        public string DetalleMateria { get; set; }

        [StringLength(250)]
        public string DetalleCalificacion { get; set; }

        [StringLength(250)]
        public string DetalleActitud { get; set; }

        [StringLength(250)]
        public string DetalleLeyenda { get; set; }

        [StringLength(250)]
        public string DetalleIncidencia { get; set; }

        [StringLength(250)]
        public string DetalleObservMaterias { get; set; }

        [StringLength(250)]
        public string DetalleObservTutor { get; set; }

        [StringLength(250)]
        public string PieObservPadre { get; set; }

        [StringLength(250)]
        public string PieSelloCentro { get; set; }

        [StringLength(250)]
        public string PieFirmaTutor { get; set; }

        [StringLength(250)]
        public string PieCentro { get; set; }

        [StringLength(250)]
        public string PieEvaluacion { get; set; }

        public string PieAlumno { get; set; }

        [StringLength(250)]
        public string PieFecha { get; set; }

        [StringLength(250)]
        public string PieCP { get; set; }

        [StringLength(250)]
        public string PieFirmaPadre { get; set; }

        [StringLength(250)]
        public string PieCursoAcademico { get; set; }

        public string PieTextObservtutor1 { get; set; }

        public string PieTextObservtutor2 { get; set; }

        [StringLength(250)]
        public string DetalleHistorial { get; set; }

        [StringLength(250)]
        public string LeyendaA { get; set; }

        [StringLength(250)]
        public string LeyendaB { get; set; }

        [StringLength(250)]
        public string LeyendaC { get; set; }

        [StringLength(250)]
        public string LeyendaD { get; set; }

        [StringLength(250)]
        public string LeyendaE { get; set; }

        public string DetalleLeyendaValoracionAspectos { get; set; }
    }
}
