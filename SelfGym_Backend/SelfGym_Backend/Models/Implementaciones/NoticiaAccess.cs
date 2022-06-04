using SelfGym_Backend.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfGym_Backend.Models.Implementaciones
{
    public class NoticiaAccess : INoticia
    {
        selfgymdb2Entities _context;

        public NoticiaAccess()
        {
            _context = new selfgymdb2Entities();
            _context.Configuration.ProxyCreationEnabled = false;

        }

        public string Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NOTICIA> Get()
        {
            return _context.NOTICIA.ToList();
        }

        public NOTICIA GetPorId(string id)
        {
            return _context.NOTICIA.FirstOrDefault(item => item.NOT_ID == id);
        }

        public string Post(NOTICIA itemNuevo)
        {
            throw new NotImplementedException();
        }

        public string Put(NOTICIA itemActualizado)
        {
            throw new NotImplementedException();
        }
    }
}