namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aspectos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aspectos()
        {
            NotaAspecto = new HashSet<NotaAspecto>();
        }

        [Key]
        public int IdAspecto { get; set; }

        public int IdCursoMateria { get; set; }

        public int IdLiteral { get; set; }

        public int? Valor { get; set; }

        public short Estado { get; set; }

        public DateTime FechaEstado { get; set; }

        public int? Orden { get; set; }

        public virtual CursoMateria CursoMateria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAspecto> NotaAspecto { get; set; }
    }
}
