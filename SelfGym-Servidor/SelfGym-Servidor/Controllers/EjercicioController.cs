using SelfGym_Servidor.Models.Implementaciones;
using SelfGym_Servidor.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SelfGym_Servidor.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EjercicioController : ApiController
    {
        readonly IEjercicio _ejercicioModelo;

        public EjercicioController()
        {
            _ejercicioModelo = new EjercicioModelo();
        }

        // GET: api/Ejercicio
        public HttpResponseMessage Get()
        {
            List<EJERCICIO> listaEjercicios = (List<EJERCICIO>)_ejercicioModelo.ObtenerTodos();
            if(listaEjercicios == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontraron ejercicios");
            }
            return Request.CreateResponse(HttpStatusCode.OK, listaEjercicios);
        }

        // GET: api/Ejercicio/5
        public EJERCICIO Get(string id)
        {
            return _ejercicioModelo.ObtenerPorCodigo(id);
        }

        // seria bueno agregar un redireccionamiento por id y codigo

        // POST: api/Ejercicio
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Ejercicio/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Ejercicio/5
        public void Delete(int id)
        {
        }
    }
}
