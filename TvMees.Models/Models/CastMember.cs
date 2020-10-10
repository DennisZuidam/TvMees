using System;
using System.Text.Json.Serialization;

namespace TvMees.Models
{
    public class CastMember
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("birthday")]
        public string birthday { get; set; }
    }
}
