using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace eveapp
{
    //[DataContract(Name="repo")]
    public class Repository
    {

        [JsonProperty("corporation_id")]
        public string CorpId { get; set; }

        [JsonProperty("birthday")]
        public string BDay { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("race_id")]
        public string Race { get; set; }

        [JsonProperty("bloodline_id")]
        public string Bloodline { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alliance_id")]
        public string Alliance { get; set; }

        [JsonProperty("ancestry_id")]
        public string Ancestry { get; set; }

        [JsonProperty("security_status")]
        public string Security { get; set; }

    }
}
