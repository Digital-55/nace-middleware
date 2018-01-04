namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log_Registro_Pasar_Lista_Familiares
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTutor { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdRegistroPasarLista { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime FechaLectura { get; set; }

        public virtual Registro_Pasar_Lista Registro_Pasar_Lista { get; set; }

        public virtual Tutor Tutor { get; set; }
    }
}
