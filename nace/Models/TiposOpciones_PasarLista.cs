namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TiposOpciones_PasarLista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TiposOpciones_PasarLista()
        {
            Registro_Pasar_Lista = new HashSet<Registro_Pasar_Lista>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoOpcionPasarLista { get; set; }

        public int IdLiteral { get; set; }

        public bool EsIncidencia { get; set; }

        public bool SinInformacion { get; set; }

        public int Orden { get; set; }

        public bool Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro_Pasar_Lista> Registro_Pasar_Lista { get; set; }
    }
}
