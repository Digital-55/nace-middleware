namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aceptacion_Usuarios
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Empresa { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool AceptaCondiciones { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Fecha { get; set; }
    }
}
