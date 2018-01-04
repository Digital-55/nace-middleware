namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Registro_Firmas_Pasar_Lista
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Hora_Inicio { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Hora_Fin { get; set; }

        public string Comentario { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime FechaFirma { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCursoGrupoMateria { get; set; }

        [Key]
        [Column(Order = 6)]
        public string Usuario { get; set; }
    }
}
