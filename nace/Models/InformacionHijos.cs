namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InformacionHijos
    {
        public int ID { get; set; }

        public int IdLiteral { get; set; }

        [Required]
        public string Pagina { get; set; }

        public virtual Literales Literales { get; set; }
    }
}
