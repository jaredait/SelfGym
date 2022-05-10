using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfGym_Servidor.PartialClasses
{
    public partial class USUARIO_RUTINA
    {
        public virtual RUTINA RUTINA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}