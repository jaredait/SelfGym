﻿using SelfGym_Backend.Models.Implementaciones;
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
    public class NoticiaController : ApiController
    {
        INoticia _access;

        public NoticiaController()
        {
            _access = new NoticiaAccess();
        }

        // GET: api/Noticia
        public HttpResponseMessage Get()
        {
            IEnumerable<NOTICIA> lista = _access.Get();
            if (lista == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontraron objetos");
            }
            return Request.CreateResponse(HttpStatusCode.OK, lista);
        }

        // GET: api/Noticia/5
        public HttpResponseMessage Get(string id)
        {
            NOTICIA item = _access.GetPorId(id);
            if (item == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"El item con id = {id} no existe");
            }
            return Request.CreateResponse(HttpStatusCode.OK, item);
        }

        // POST: api/Noticia
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Noticia/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Noticia/5
        public void Delete(int id)
        {
        }
    }
}
