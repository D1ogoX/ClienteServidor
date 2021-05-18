using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using API.Models;

namespace API.Controllers
{
    [RoutePrefix("api/utilizador")]
    public class UtilizadorController : ApiController
    {
        private Exemplo_ESAPEntities db = new Exemplo_ESAPEntities();

        // GET: api/Utilizador/5
        [ResponseType(typeof(tbUtilizador))]
        //Sistema de autorização individual para cada EndPoint
        [Authorize]
        public IHttpActionResult GettbUtilizador(string id)
        {
            tbUtilizador tbUtilizador = db.tbUtilizador.Find(id);
            if (tbUtilizador == null)
            {
                return NotFound();
            }

            return Ok(tbUtilizador);
        }

        // POST: api/Utilizador
        [ResponseType(typeof(tbUtilizador))]
        public HttpResponseMessage PosttbUtilizador(tbUtilizador tbUtilizador)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.tbUtilizador.Add(tbUtilizador);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tbUtilizadorExists(tbUtilizador.email))
                {
                    return Request.CreateResponse(HttpStatusCode.Conflict);
                }
                else
                {
                    throw;
                }
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbUtilizadorExists(string id)
        {
            return db.tbUtilizador.Count(e => e.email == id) > 0;
        }
    }
}