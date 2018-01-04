namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tipo_InformePsicopedagogico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_InformePsicopedagogico()
        {
            InformePsicopedagogico = new HashSet<InformePsicopedagogico>();
        }

        public int ID { get; set; }

        public int IdLiteral { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InformePsicopedagogico> InformePsicopedagogico { get; set; }

        public virtual Literales Literales { get; set; }
    }
}
