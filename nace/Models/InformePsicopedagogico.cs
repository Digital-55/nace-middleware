namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InformePsicopedagogico")]
    public partial class InformePsicopedagogico
    {
        public int ID { get; set; }

        public int IdAlumno { get; set; }

        public DateTime Fecha { get; set; }

        public int TipoInforme { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Asunto { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(9)]
        public string Curso { get; set; }

        public byte[] Adjunto { get; set; }

        [StringLength(10)]
        public string TipoAdjunto { get; set; }

        [StringLength(200)]
        public string NombreAdjunto { get; set; }

        public virtual Tipo_InformePsicopedagogico Tipo_InformePsicopedagogico { get; set; }
    }
}
