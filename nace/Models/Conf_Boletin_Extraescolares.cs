namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Conf_Boletin_Extraescolares
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_Alumno { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_Extraescolares { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Extraescolares { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_Evaluacion { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Sello_Colegio { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_Colegio { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Nombre_Colegio { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_CursoAcademico { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_FirmaFamiliar { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_ObservacionesActividades { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_ObservacionesFamiliar { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_Materia { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_Calificacion { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_Historico { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_Evaluacion1 { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_Evaluacion2 { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_Evaluacion3 { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Literal_Titulo_Evaluacion4 { get; set; }

        public virtual Literales Literales { get; set; }

        public virtual Literales Literales1 { get; set; }

        public virtual Literales Literales2 { get; set; }

        public virtual Literales Literales3 { get; set; }

        public virtual Literales Literales4 { get; set; }

        public virtual Literales Literales5 { get; set; }

        public virtual Literales Literales6 { get; set; }

        public virtual Literales Literales7 { get; set; }

        public virtual Literales Literales8 { get; set; }

        public virtual Literales Literales9 { get; set; }

        public virtual Literales Literales10 { get; set; }

        public virtual Literales Literales11 { get; set; }

        public virtual Literales Literales12 { get; set; }

        public virtual Literales Literales13 { get; set; }

        public virtual Literales Literales14 { get; set; }

        public virtual Literales Literales15 { get; set; }

        public virtual Literales Literales16 { get; set; }

        public virtual Literales Literales17 { get; set; }
    }
}
