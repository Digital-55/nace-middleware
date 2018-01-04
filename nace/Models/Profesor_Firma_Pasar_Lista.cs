namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Profesor_Firma_Pasar_Lista
    {
        public int ID { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        public string Usuario { get; set; }

        public int IdHorario { get; set; }

        public string Comentario { get; set; }

        public DateTime? FECHA_FIRMA { get; set; }

        public virtual Horario Horario { get; set; }
    }
}
