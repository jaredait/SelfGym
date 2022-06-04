using SelfGym_Backend.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfGym_Backend.Models.Implementaciones
{
    public class UsuarioAccess : IUsuario
    {
        selfgymdb2Entities _context;

        public UsuarioAccess()
        {
            _context = new selfgymdb2Entities();
            _context.Configuration.ProxyCreationEnabled = false;

        }

        public string Delete(string id)
        {
            USUARIO temp = GetPorId(id);
            _context.USUARIO.Remove(temp);
            _context.SaveChanges();
            return id;
        }

        public IEnumerable<USUARIO> Get()
        {
            return _context.USUARIO.ToList();
        }

        public USUARIO GetPorId(string id)
        {
            return _context.USUARIO.FirstOrDefault(item => item.USU_ID == id);
        }

        public string Post(USUARIO itemNuevo)
        {
            _context.USUARIO.Add(itemNuevo);
            _context.SaveChanges();
            return itemNuevo.USU_ID;
        }

        public string Put(USUARIO itemActualizado)
        {
            USUARIO temp = GetPorId(itemActualizado.USU_ID);
            temp.USU_ID = itemActualizado.USU_ID;
            temp.USU_CONTRASENA = itemActualizado.USU_CONTRASENA;
            temp.USU_EMAIL = itemActualizado.USU_EMAIL;
            temp.USU_EDAD = itemActualizado.USU_EDAD;
            _context.SaveChanges();
            return itemActualizado.USU_ID;
        }
    }
}