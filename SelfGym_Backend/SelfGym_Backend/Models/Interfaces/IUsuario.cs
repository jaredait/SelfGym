using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfGym_Backend.Models.Interfaces
{
    public interface IUsuario
    {
        IEnumerable<USUARIO> Get();
        USUARIO GetPorId(string id);
        string Post(USUARIO itemNuevo);
        string Put(USUARIO itemActualizado);
        string Delete(string id);
    }
}
