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
    //Define a rota padrão:
    [RoutePrefix("api/anuncios")]
    //Define que só se pode aceder a este controller quando estiver autenticado:
    [Authorize]
    public class AnunciosController : ApiController
    {
        /**
         * Todos estes endpoints foram gerados automaticamente pelo visual studio
         * 
         * Adicionar controller com EntityFramework e selecionando o modelo ele cria automaticamente
        */

        private Exemplo_ESAPEntities db = new Exemplo_ESAPEntities();

        /// <summary>
        /// Obter todos os anúncios
        /// GET: api/Anuncios
        /// </summary>
        /// <returns></returns>
        public IQueryable<tbAnuncios> GettbAnuncios()
        {
            return db.tbAnuncios;
        }

        /// <summary>
        /// Obter um anúncio pelo ID
        /// GET: api/Anuncios/5
        /// </summary>
        /// <param name="id">ID do anúncio</param>
        /// <returns></returns>
        [ResponseType(typeof(tbAnuncios))]
        public IHttpActionResult GettbAnuncios(int id)
        {
            tbAnuncios tbAnuncios = db.tbAnuncios.Find(id);
            if (tbAnuncios == null)
            {
                return NotFound();
            }

            return Ok(tbAnuncios);
        }

        /// <summary>
        /// Edita um anúncio
        /// PUT: api/Anuncios/5
        /// </summary>
        /// <param name="id">ID do anúncio</param>
        /// <param name="tbAnuncios">Anúncio com todos os campos a serem editados, normalmente vem no body do request</param>
        /// <returns></returns>
        [ResponseType(typeof(void))]
        public HttpResponseMessage PuttbAnuncios(int id, tbAnuncios tbAnuncio)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            if (id != tbAnuncio.idAnuncio)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(tbAnuncio).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbAnunciosExists(id))
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                else
                {
                    throw;
                }
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        /// <summary>
        /// Adiciona um anuncio
        /// POST: api/Anuncios/Adicionar
        /// </summary>
        /// <param name="tbAnuncios">Modelo "tbAnuncios"</param>
        /// <returns>HttpStatusCode consuante consiga adicionar ou não</returns>
        [ResponseType(typeof(tbAnuncios))]
        //Adicionar um EndPoint personalizado a este método
        [Route("adicionar")]
        public HttpResponseMessage PosttbAnuncios(tbAnuncios tbAnuncios)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            //Adicionar o idUtilizador automaticamente
            //Isto dá para fazer porque o utilizador "apresenta" um token de acesso que indica qual é o utilizador
            tbAnuncios.idUtilizador = Convert.ToInt32(RequestContext.Principal.Identity.Name);

            db.tbAnuncios.Add(tbAnuncios);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK, tbAnuncios.idAnuncio);
        }

        /// <summary>
        /// Apaga um anúncio
        /// DELETE: api/Anuncios/5
        /// </summary>
        /// <param name="id">ID do anúncio</param>
        /// <returns></returns>
        [ResponseType(typeof(tbAnuncios))]
        public HttpResponseMessage DeletetbAnuncios(int id)
        {
            tbAnuncios tbAnuncios = db.tbAnuncios.Find(id);
            if (tbAnuncios == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.tbAnuncios.Remove(tbAnuncios);
            db.SaveChanges();

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

        private bool tbAnunciosExists(int id)
        {
            return db.tbAnuncios.Count(e => e.idAnuncio == id) > 0;
        }
    }
}