using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfGym_Servidor.PartialClasses
{
    public partial class RUTINA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RUTINA()
        {
            this.RUTINA_EJERCICIO = new HashSet<RUTINA_EJERCICIO>();
            this.USUARIO_RUTINA = new HashSet<USUARIO_RUTINA>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RUTINA_EJERCICIO> RUTINA_EJERCICIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_RUTINA> USUARIO_RUTINA { get; set; }
    }
}