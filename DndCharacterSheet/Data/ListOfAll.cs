using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndCharacterSheet.Data
{
    public class ListOfAll
    {
        [JsonProperty("count")]
        public int count { get; set; }

        [JsonProperty("results")]
        public List<Result> results { get; set; }
    }
    public class Result
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }
    }
}
