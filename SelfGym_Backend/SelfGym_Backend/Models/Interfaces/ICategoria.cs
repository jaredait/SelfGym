using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfGym_Backend.Models.Interfaces
{
    public interface ICategoria
    {
        IEnumerable<CATEGORIA> Get();
        CATEGORIA GetPorId(string id);
        string Post(CATEGORIA itemNuevo);
        string Put(CATEGORIA itemActualizado);
        string Delete(string id);
    }
}
