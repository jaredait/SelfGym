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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.USUARIO_RUTINA = new HashSet<USUARIO_RUTINA>();
        }
    
        public string USU_NOMBREUSUARIO { get; set; }
        public string USU_CONTRASENA { get; set; }
        public string USU_NOMBRE { get; set; }
        public string USU_APELLIDO { get; set; }
        public Nullable<int> USU_EDAD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_RUTINA> USUARIO_RUTINA { get; set; }
    }
}
