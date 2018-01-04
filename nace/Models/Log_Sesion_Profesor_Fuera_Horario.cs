namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log_Sesion_Profesor_Fuera_Horario
    {
        public int ID { get; set; }

        public DateTime? Fecha { get; set; }

        public int? IdProfesor { get; set; }

        public int? Hora { get; set; }
    }
}
