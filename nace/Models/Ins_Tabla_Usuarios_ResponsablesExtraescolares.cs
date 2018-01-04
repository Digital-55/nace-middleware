namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ins_Tabla_Usuarios_ResponsablesExtraescolares
    {
        public int ID { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Nombre_Usuario { get; set; }

        public string Email { get; set; }
    }
}
