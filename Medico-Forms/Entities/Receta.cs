using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Medico_Forms.Entities
{
    public class Receta
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nombre_paciente")]
        public string NombrePaciente { get; set; }
        [JsonPropertyName("apellido_paciente")]
        public string ApellidoPaciente { get; set; }
        [JsonPropertyName("fecha")]
        public DateTime Fecha { get; set; }
        [JsonPropertyName("diagnostico")]
        public string Diagnostico { get; set; }
        [JsonPropertyName("medicamentos")]
        public string Medicamentos { get; set; }
        [JsonPropertyName("estado")]
        public string Estado { get; set; }
        public Receta()
        {
            
        }
    }
}
