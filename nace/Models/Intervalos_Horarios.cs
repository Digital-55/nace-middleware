namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Intervalos_Horarios
    {
        public int ID { get; set; }

        public DateTime HoraInicio { get; set; }

        public DateTime HoraFin { get; set; }

        public int Orden { get; set; }

        public short IdNivel { get; set; }

        public int ANYO { get; set; }

        public virtual Intervalos_Horarios Intervalos_Horarios1 { get; set; }

        public virtual Intervalos_Horarios Intervalos_Horarios2 { get; set; }

        public virtual Nivel Nivel { get; set; }
    }
}
