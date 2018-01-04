namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log_Mod_NotasRecuperacion
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string ACCION { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Usuario_Realiza { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Nombre_Usuario_Realiza { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Fecha_Accion { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdNotaRecuperacion { get; set; }

        public int? IdNotaAlumno { get; set; }

        public DateTime? FechaNota { get; set; }

        [StringLength(50)]
        public string Nota { get; set; }

        public DateTime? FechaNota_Old { get; set; }

        [StringLength(50)]
        public string Nota_Old { get; set; }
    }
}
