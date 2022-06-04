using SelfGym_Backend.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfGym_Backend.Models.Implementaciones
{
    public class CategoriaAccess : ICategoria
    {
        selfgymdb2Entities _context;

        public CategoriaAccess()
        {
            _context = new selfgymdb2Entities();
            _context.Configuration.ProxyCreationEnabled = false;

        }

        public string Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CATEGORIA> Get()
        {
            return _context.CATEGORIA.ToList();
        }

        public CATEGORIA GetPorId(string id)
        {
            return _context.CATEGORIA.FirstOrDefault(item => item.CAT_ID == id);
        }

        public string Post(CATEGORIA itemNuevo)
        {
            throw new NotImplementedException();
        }

        public string Put(CATEGORIA itemActualizado)
        {
            throw new NotImplementedException();
        }
    }
}