using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SelfGym_Servidor.PartialClasses
{
    public partial class EJERCICIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EJERCICIO()
        {
            this.RUTINA_EJERCICIO = new List<RUTINA_EJERCICIO>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [XmlIgnore]
        public virtual IEnumerable<RUTINA_EJERCICIO> RUTINA_EJERCICIO { get; set; }
    }
}