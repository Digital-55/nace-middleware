namespace nace.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARGA_EMPLEADOS
    {
        public int ID { get; set; }

        public int? COLECTIVO_FISCAL { get; set; }

        public string APELLIDOS_NOMBRE { get; set; }

        public string NIF { get; set; }

        public int? EMPLEADO_COD { get; set; }

        public decimal? HORAS_SEMANALES { get; set; }

        public decimal? PORCENTAJE_DEDICACION { get; set; }

        public string CATEGORIA_DES { get; set; }

        public string MINI_PUESTO_DENOMINACION_DES { get; set; }

        public string EMPRESA_GRUPO { get; set; }

        public bool? ACTUALIZADO_EMPLEADO { get; set; }

        public bool? ACTUALIZADO_PROFESOR { get; set; }
    }
}
