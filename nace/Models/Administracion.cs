namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Administracion")]
    public partial class Administracion
    {
        [Key]
        public int IdAdministracion { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido1 { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido2 { get; set; }

        public short Estado { get; set; }

        public DateTime FechaEstado { get; set; }

        public bool? Visible { get; set; }

        public bool? RecibeCorreo { get; set; }

        public bool? RolSecretaria { get; set; }
    }
}
