namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nivel")]
    public partial class Nivel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nivel()
        {
            Ciclo = new HashSet<Ciclo>();
            ConfigEvalResum = new HashSet<ConfigEvalResum>();
            ConfigResumEval = new HashSet<ConfigResumEval>();
            EquivalenciaNotas = new HashSet<EquivalenciaNotas>();
            EquivalenciasTiposMaterias = new HashSet<EquivalenciasTiposMaterias>();
            Evaluacion = new HashSet<Evaluacion>();
            Intervalos_Horarios = new HashSet<Intervalos_Horarios>();
            ObservGenerica = new HashSet<ObservGenerica>();
            ValoracionAspecto = new HashSet<ValoracionAspecto>();
        }

        [Key]
        public short IdNivel { get; set; }

        public int IdLiteral { get; set; }

        [StringLength(2)]
        public string CodNivel { get; set; }

        [StringLength(2)]
        public string NumFamDimoni { get; set; }

        public bool Estado { get; set; }

        public bool? Extraescolares { get; set; }

        public bool? Interno { get; set; }

        public bool? BoletinUnificado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ciclo> Ciclo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfigEvalResum> ConfigEvalResum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfigResumEval> ConfigResumEval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquivalenciaNotas> EquivalenciaNotas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquivalenciasTiposMaterias> EquivalenciasTiposMaterias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluacion> Evaluacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Intervalos_Horarios> Intervalos_Horarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObservGenerica> ObservGenerica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValoracionAspecto> ValoracionAspecto { get; set; }
    }
}
