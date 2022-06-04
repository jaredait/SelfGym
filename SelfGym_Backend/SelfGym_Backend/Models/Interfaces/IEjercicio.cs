using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfGym_Backend.Models.Interfaces
{
    public interface IEjercicio
    {
        IEnumerable<EJERCICIO> Get();
        EJERCICIO GetPorId(string id);
        string Post(EJERCICIO itemNuevo);
        string Put(EJERCICIO itemActualizado);
        string Delete(string id);
    }
}
