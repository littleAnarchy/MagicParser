using Newtonsoft.Json;

namespace Common
{
    public class SpellModel
    {
        [JsonProperty("SpellName")]
        public string SpellName { get; set; }
        [JsonProperty("SpellDescription")]
        public string SpellDescription { get; set; }
        [JsonProperty("SpellText")]
        public string SpellText { get; set; }
        [JsonProperty("SpellAddedDescription")]
        public string SpellAddedDescription { get; set; }
        [JsonProperty("SpellTypeId")]
        public int SpellTypeId { get; set; }
    }
}
