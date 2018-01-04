namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Distribucion_Correo
    {
        [Key]
        public int IDDistribucion { get; set; }

        public int IDRole { get; set; }

        public int IDRoleDestino { get; set; }

        public int IDAlcance { get; set; }

        public virtual Tipo_Alcance_Correo Tipo_Alcance_Correo { get; set; }

        public virtual Roles_Correo Roles_Correo { get; set; }

        public virtual Roles_Correo Roles_Correo1 { get; set; }
    }
}
