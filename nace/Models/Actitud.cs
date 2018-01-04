namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Actitud")]
    public partial class Actitud
    {
        public int ID { get; set; }

        public int? IdLiteral { get; set; }

        public string Desc { get; set; }

        public virtual Literales Literales { get; set; }
    }
}
