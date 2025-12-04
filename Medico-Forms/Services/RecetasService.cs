using Medico_Forms.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medico_Forms.Services
{
    public class RecetasService
    {
        private HttpClient client = new HttpClient();
        private String baseUrl;
        public RecetasService(String baseURL)
        {
            this.baseUrl = baseURL;
        }

        public async Task<Receta> createreceta(Receta receta)
        {
            try
            {
                string url = this.baseUrl;
                string body = JsonSerializer.Serialize(receta);
                Console.WriteLine(body);
                var content = new StringContent(body, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);

                Receta responsereceta = JsonSerializer.Deserialize<Receta>(responseBody);
                return responsereceta;
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show(
                    "Error al insertar la receta " + e.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return null;
            }
        }
    }
}
