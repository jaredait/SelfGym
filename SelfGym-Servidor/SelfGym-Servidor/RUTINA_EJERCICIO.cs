//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SelfGym_Servidor
{
    using System;
    using System.Collections.Generic;
    
    public partial class RUTINA_EJERCICIO
    {
        public int RUT_EJE_ID { get; set; }
        public Nullable<int> RUT_ID { get; set; }
        public Nullable<int> EJE_ID { get; set; }
    
        public virtual EJERCICIO EJERCICIO { get; set; }
        public virtual RUTINA RUTINA { get; set; }
    }
}