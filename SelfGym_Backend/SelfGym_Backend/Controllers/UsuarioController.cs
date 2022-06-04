using SelfGym_Backend.Models.Implementaciones;
using SelfGym_Backend.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SelfGym_Backend.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsuarioController : ApiController
    {
        IUsuario _access;

        public UsuarioController()
        {
            _access = new UsuarioAccess();
        }

        // GET: api/Usuario
        public HttpResponseMessage Get()
        {
            IEnumerable<USUARIO> lista = _access.Get();
            if (lista == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontraron objetos");
            }
            return Request.CreateResponse(HttpStatusCode.OK, lista);
        }

        // GET: api/Usuario/5
        public HttpResponseMessage Get(string id)
        {
            USUARIO item = _access.GetPorId(id);
            if (item == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"El item con id = {id} no existe");
            }
            return Request.CreateResponse(HttpStatusCode.OK, item);
        }

        // POST: api/Usuario
        public HttpResponseMessage Post([FromBody]USUARIO item)
        {
            try
            {
                _access.Post(item);

                var mensaje = Request.CreateResponse(HttpStatusCode.Created, item);
                mensaje.Headers.Location = new Uri(Request.RequestUri + item.USU_ID.ToString());

                return mensaje;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // PUT: api/Usuario/5
        public HttpResponseMessage Put([FromBody]USUARIO item)
        {
            try
            {
                string itemTemp = _access.Put(item);

                if (String.IsNullOrEmpty(itemTemp))
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"El item con id = {item.USU_ID} no existe");
                }
                return Request.CreateResponse(HttpStatusCode.OK, itemTemp);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // DELETE: api/Usuario/5
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                string operacionExitosa = _access.Delete(id);
                if (String.IsNullOrEmpty(operacionExitosa))
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"El item con id = {id} no existe");
                }
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
