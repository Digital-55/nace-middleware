namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Registro_Alertas_SMS
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Origen_SMS { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Tlf_Envio { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(160)]
        public string Texto_SMS { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Nombre_Usuario_Recibe_SMS { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime Fecha_Creacion_Entrada { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Aprobado_Envio { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Enviado { get; set; }

        public DateTime? Fecha_Envio { get; set; }

        public bool? Enviado_Correctamente { get; set; }

        public string Error { get; set; }

        public bool? Estado { get; set; }

        public string Usuario_Borrado { get; set; }

        public DateTime? Fecha_Borrado { get; set; }

        public bool? Rechazado_Envio { get; set; }

        public string CURSO { get; set; }

        public string Perfil { get; set; }

        public string USUARIO_CREATE { get; set; }

        public string USUARIO_PROCESA { get; set; }

        public DateTime? FECHA_PROCESADO { get; set; }
    }
}
