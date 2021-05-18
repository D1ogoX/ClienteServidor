using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Models
{
    class tbAnuncios
    {
        public int idAnuncio { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public System.DateTime dataCriado { get; set; }
        public int idUtilizador { get; set; }
        public bool publicado { get; set; }

        public static async Task<List<tbAnuncios>> getTodosAnuncios()
        {
            try
            {
                string _sContent = await Utils.client.GetStringAsync(Utils.sServidor + "api/anuncios");

                return JsonConvert.DeserializeObject<List<tbAnuncios>>(_sContent);
            }

            catch
            {
                return new List<tbAnuncios>();
            }
        }

        public static async Task<tbAnuncios> getAnuncioCodigo(int _iCodigo)
        {
            try
            {
                string _sContent = await Utils.client.GetStringAsync(Utils.sServidor + "api/anuncios/" + _iCodigo);

                return JsonConvert.DeserializeObject<tbAnuncios>(_sContent);
            }

            catch
            {
                return new tbAnuncios();
            }
        }

        public static async Task<Boolean> adiciona(Models.tbAnuncios _anuncio)
        {
            try
            {
                Uri _uri = new Uri(Utils.sServidor + "api/anuncios/adicionar");

                var data = JsonConvert.SerializeObject(_anuncio);
                var content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;

                response = await Utils.client.PostAsync(_uri, content);

                string _sContent = await response.Content.ReadAsStringAsync();

                //System.Windows.Forms.MessageBox.Show(_sContent + " - " + response.StatusCode);

                Debug.WriteLine(_sContent);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch
            {
                return false;
            }
        }

        public static async Task<Boolean> editar(Models.tbAnuncios _anuncio)
        {
            try
            {
                Uri _uri = new Uri(Utils.sServidor + "api/anuncios/" + _anuncio.idAnuncio);

                var data = JsonConvert.SerializeObject(_anuncio);
                var content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;

                response = await Utils.client.PutAsync(_uri, content);

                string _sContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch
            {
                return false;
            }
        }

        public static async Task<Boolean> apagar(int _iCodigoAnuncio)
        {
            try
            {
                HttpResponseMessage response = null;

                response = await Utils.client.DeleteAsync(Utils.sServidor + "api/anuncios/" + _iCodigoAnuncio);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch
            {
                return false;
            }
        }
    }
}
