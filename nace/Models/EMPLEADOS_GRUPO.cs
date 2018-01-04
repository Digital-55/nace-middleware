namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPLEADOS_GRUPO
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string COD_EMPLEADO { get; set; }

        [Key]
        [Column(Order = 2)]
        public string NIF { get; set; }

        [Key]
        [Column(Order = 3)]
        public string NOMBRE_EMPLEADO { get; set; }

        [Key]
        [Column(Order = 4)]
        public string EMPRESA { get; set; }

        [StringLength(2)]
        public string COD_EMPRESA { get; set; }
    }
}
