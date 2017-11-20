using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class StationBoardRoot
    {
        [JsonProperty("Station")]
        public Station Station { get; set; }

        [JsonProperty("stationboard")]
        public List<StationBoard> Entries { get; set; }
    }

    public class StationBoard
    {
        [JsonProperty("stop")]
        public Stop Stop { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }
    }

    public class Stop
    {
        [JsonProperty("departure")]
        public DateTime Departure { get; set; }

        public override string ToString()
        {
            return Departure.ToString("dd.mm.yyyy, HH.mm");
        }
    }
}