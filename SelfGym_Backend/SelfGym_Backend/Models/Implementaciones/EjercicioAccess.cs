using SelfGym_Backend.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfGym_Backend.Models.Implementaciones
{
    public class EjercicioAccess : IEjercicio
    {
        selfgymdb2Entities _context;

        public EjercicioAccess()
        {
            _context = new selfgymdb2Entities();
            _context.Configuration.ProxyCreationEnabled = false;

        }

        public string Delete(string id)
        {
            EJERCICIO temp = GetPorId(id);
            _context.EJERCICIO.Remove(temp);
            _context.SaveChanges();
            return id;
        }

        public IEnumerable<EJERCICIO> Get()
        {
            return _context.EJERCICIO.ToList();
        }

        public EJERCICIO GetPorId(string id)
        {
            return _context.EJERCICIO.FirstOrDefault(item => item.EJE_ID == id);
        }

        public string Post(EJERCICIO itemNuevo)
        {
            _context.EJERCICIO.Add(itemNuevo);
            _context.SaveChanges();
            return itemNuevo.EJE_ID;
        }

        public string Put(EJERCICIO itemActualizado)
        {
            EJERCICIO temp = GetPorId(itemActualizado.EJE_ID);
            temp.CAT_ID = itemActualizado.CAT_ID;
            temp.EJE_NOMBRE = itemActualizado.EJE_NOMBRE;
            temp.EJE_DESCRIPCION = itemActualizado.EJE_DESCRIPCION;
            temp.EJE_URLVIDEO = itemActualizado.EJE_URLVIDEO;
            _context.SaveChanges();
            return itemActualizado.EJE_ID;
        }
    }
}