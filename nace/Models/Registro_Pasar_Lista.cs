namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Registro_Pasar_Lista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Registro_Pasar_Lista()
        {
            Log_Registro_Pasar_Lista_Familiares = new HashSet<Log_Registro_Pasar_Lista_Familiares>();
        }

        public int ID { get; set; }

        public int IdAlumno { get; set; }

        public DateTime FechaCreacion { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        public int IdTipoOpcionPasarLista { get; set; }

        [Required]
        public string HoraInicio { get; set; }

        [Required]
        public string HoraFin { get; set; }

        public int IdCursoGrupoMateria { get; set; }

        [Required]
        public string Usuario { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual CursoGrupoMateria CursoGrupoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log_Registro_Pasar_Lista_Familiares> Log_Registro_Pasar_Lista_Familiares { get; set; }

        public virtual TiposOpciones_PasarLista TiposOpciones_PasarLista { get; set; }
    }
}
