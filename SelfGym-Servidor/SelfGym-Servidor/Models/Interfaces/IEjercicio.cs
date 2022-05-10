using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfGym_Servidor.Models.Interfaces
{
    interface IEjercicio
    {
        IEnumerable ObtenerTodos();
        EJERCICIO ObtenerPorId(int id);
        EJERCICIO ObtenerPorCodigo(string codigo);
    }
}
