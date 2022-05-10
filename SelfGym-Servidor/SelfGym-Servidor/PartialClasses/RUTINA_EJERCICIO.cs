using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfGym_Servidor.PartialClasses
{
	public partial class RUTINA_EJERCICIO
	{
		public virtual EJERCICIO EJERCICIO { get; set; }
		public virtual RUTINA RUTINA { get; set; }
	}
}