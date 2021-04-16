using System.Text.Json.Serialization;

namespace RefazendoADemo.Models
{
    public class RandoMizeResponse
    {
        public bool Success { get; set; }
        [JsonPropertyName("deck_id")]
        public string DeckId { get; set; }
        public bool Shuffled { get; set; }
        public int Remaining { get; set; }
    }
}
