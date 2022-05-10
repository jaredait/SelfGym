using SelfGym_Servidor.Models.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfGym_Servidor.Models.Implementaciones
{
    public class EjercicioModelo : IEjercicio
    {
        readonly private selfgymdbEntities _contexto;

        public EjercicioModelo()
        {
            _contexto = new selfgymdbEntities();
        }

        public EJERCICIO ObtenerPorCodigo(string codigo)
        {
            try
            {
                return _contexto.EJERCICIO.Where(e => e.EJE_CODIGO == codigo).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EJERCICIO ObtenerPorId(int id)
        {
            try
            {
                return _contexto.EJERCICIO.Where(e => e.EJE_ID == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable ObtenerTodos()
        {
            try
            {
                return _contexto.EJERCICIO.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}