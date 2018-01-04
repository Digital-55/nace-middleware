namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Horario")]
    public partial class Horario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Horario()
        {
            Incidencia = new HashSet<Incidencia>();
            Profesor_Firma_Pasar_Lista = new HashSet<Profesor_Firma_Pasar_Lista>();
        }

        [Key]
        public int IdHorario { get; set; }

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

        public bool? VIENE_UNTIS { get; set; }

        public bool? ModuloInscripcion { get; set; }

        public virtual CursoGrupoMateria CursoGrupoMateria { get; set; }

        public virtual DiaSemana DiaSemana { get; set; }

        public virtual Profesor Profesor { get; set; }

        public virtual Tipo_RRHH Tipo_RRHH { get; set; }

        public virtual TipoHorario TipoHorario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incidencia> Incidencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Profesor_Firma_Pasar_Lista> Profesor_Firma_Pasar_Lista { get; set; }
    }
}
