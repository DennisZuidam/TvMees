using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace TvMees.Models
{
    public class TvShow
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
