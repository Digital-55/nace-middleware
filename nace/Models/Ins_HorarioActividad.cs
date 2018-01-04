namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_HorarioActividad
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdActividad { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dia { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string HoraInicio { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(5)]
        public string HoraFin { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumPlazas { get; set; }

        public int? IdProfesor { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Paquete { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool EstadoHorario { get; set; }
    }
}
