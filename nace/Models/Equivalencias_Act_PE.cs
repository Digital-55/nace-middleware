namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Equivalencias_Act_PE
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCursoGrupoMateria { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CodArticulo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(8)]
        public string Seccion { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(11)]
        public string CentroCoste { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Descuento { get; set; }
    }
}
