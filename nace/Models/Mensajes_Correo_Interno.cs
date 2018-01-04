namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mensajes_Correo_Interno
    {
        [Key]
        public int IDMensaje { get; set; }

        [Required]
        public string IDUsuarioEmisor_Role { get; set; }

        [Required]
        public string IDUsuarioDestino_Role { get; set; }

        public bool NoLeido { get; set; }

        public bool Importante { get; set; }

        [StringLength(100)]
        public string Asunto { get; set; }

        public string Mensaje { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaEnvio { get; set; }

        public DateTime? FechaLectura { get; set; }

        public DateTime? FechaBorrado { get; set; }

        public bool AcuseRecibo { get; set; }
    }
}
