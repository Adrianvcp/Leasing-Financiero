//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanzasTrabajoFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class nameBanco
    {
        public int idBanco { get; set; }
        public int idUsuario { get; set; }
        public string NombreBanco { get; set; }
        public float TEA { get; set; }
        public float SeguroRiesgo { get; set; }
        public float PorRecompa { get; set; }
        public float costesNotariales { get; set; }
        public float costesRegistrales { get; set; }
        public float Tasacion { get; set; }
        public float comEstudio { get; set; }
        public Nullable<float> comActivacion { get; set; }
        public float comPeriodica { get; set; }
        public float PorsegRiesgo { get; set; }
        public float ks { get; set; }
        public float wacc { get; set; }
    }
}
