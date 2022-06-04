using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfGym_Backend.Models.Interfaces
{
    public interface INoticia
    {
        IEnumerable<NOTICIA> Get();
        NOTICIA GetPorId(string id);
        string Post(NOTICIA itemNuevo);
        string Put(NOTICIA itemActualizado);
        string Delete(string id);
    }
}
