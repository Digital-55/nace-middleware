namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoIncidencia")]
    public partial class TipoIncidencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoIncidencia()
        {
            Incidencia = new HashSet<Incidencia>();
        }

        [Key]
        public short IdTipoIncidencia { get; set; }

        public int IdLiteral { get; set; }

        public bool Estado { get; set; }

        public bool? EsRetraso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incidencia> Incidencia { get; set; }

        public virtual Literales Literales { get; set; }
    }
}
