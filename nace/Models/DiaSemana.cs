namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiaSemana")]
    public partial class DiaSemana
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiaSemana()
        {
            Horario = new HashSet<Horario>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IdDiaSemana { get; set; }

        public int IdLiteral { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horario> Horario { get; set; }
    }
}
