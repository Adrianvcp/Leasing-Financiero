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
    
    public partial class Banco_Promocion
    {
        public int Banco_idBanco { get; set; }
        public int Promocion_idPromocion { get; set; }
        public int carro_idCarro { get; set; }
    
        public virtual Banco Banco { get; set; }
        public virtual carro carro { get; set; }
        public virtual Promocion Promocion { get; set; }
    }
}