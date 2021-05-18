using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Models
{
    class tbUtilizador
    {
        public int idUtilizador { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string nome { get; set; }
        public Nullable<System.Guid> UUID { get; set; }
        public System.DateTime dataCriado { get; set; }

        public static async Task<Boolean> verificaLogin(string _sUsername, string _sPassword)
        {
            try
            {
                var keyValues = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("username", _sUsername),
                    new KeyValuePair<string, string>("password", Utils.Encriptar(_sPassword)),
                    new KeyValuePair<string, string>("grant_type", "password")
                };

                var request = new HttpRequestMessage(HttpMethod.Post, Utils.sServidor + "token");

                request.Content = new FormUrlEncodedContent(keyValues);

                var client = new HttpClient();

                var response = await client.SendAsync(request);

                var jwt = await response.Content.ReadAsStringAsync();

                Debug.WriteLine(jwt);

                if (response.IsSuccessStatusCode)
                {
                    JObject jwtDynamic = JsonConvert.DeserializeObject<dynamic>(jwt);

                    var accessToken = jwtDynamic.Value<string>("access_token");

                    Utils.sToken = accessToken;

                    Utils.client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

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

        public static async Task<Boolean> adiciona(Models.tbUtilizador _utilizador)
        {
            try
            {
                Uri _uri = new Uri(Utils.sServidor + "api/utilizador");

                var data = JsonConvert.SerializeObject(_utilizador);
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
    }
}
