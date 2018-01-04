namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Literales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Literales()
        {
            Actitud = new HashSet<Actitud>();
            EquivalenciaNotas = new HashSet<EquivalenciaNotas>();
            Evaluacion = new HashSet<Evaluacion>();
            InformacionHijos = new HashSet<InformacionHijos>();
            LINKS_CURSOGRUPO = new HashSet<LINKS_CURSOGRUPO>();
            Conf_Boletin_Extraescolares = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares1 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares2 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares3 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares4 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares5 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares6 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares7 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares8 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares9 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares10 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares11 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares12 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares13 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares14 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares15 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares16 = new HashSet<Conf_Boletin_Extraescolares>();
            Conf_Boletin_Extraescolares17 = new HashSet<Conf_Boletin_Extraescolares>();
            Tipo_InformePsicopedagogico = new HashSet<Tipo_InformePsicopedagogico>();
            MedidasEducativas = new HashSet<MedidasEducativas>();
            Roles_Correo = new HashSet<Roles_Correo>();
            Tipo_Alcance_Correo = new HashSet<Tipo_Alcance_Correo>();
            Tipo_Lateralidad = new HashSet<Tipo_Lateralidad>();
            TipoIncidencia = new HashSet<TipoIncidencia>();
            Traducciones = new HashSet<Traducciones>();
            ValoracionAspecto = new HashSet<ValoracionAspecto>();
        }

        [Key]
        public int IdLiteral { get; set; }

        [Required]
        [StringLength(255)]
        public string Clave { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actitud> Actitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquivalenciaNotas> EquivalenciaNotas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluacion> Evaluacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InformacionHijos> InformacionHijos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LINKS_CURSOGRUPO> LINKS_CURSOGRUPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares6 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares7 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares8 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares9 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares10 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares11 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares12 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares13 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares14 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares15 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares16 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conf_Boletin_Extraescolares> Conf_Boletin_Extraescolares17 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tipo_InformePsicopedagogico> Tipo_InformePsicopedagogico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedidasEducativas> MedidasEducativas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Roles_Correo> Roles_Correo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tipo_Alcance_Correo> Tipo_Alcance_Correo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tipo_Lateralidad> Tipo_Lateralidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoIncidencia> TipoIncidencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Traducciones> Traducciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValoracionAspecto> ValoracionAspecto { get; set; }
    }
}
