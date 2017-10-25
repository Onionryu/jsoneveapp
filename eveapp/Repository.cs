using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace eveapp
{
    [DataContract(Name="repo")]
    public class Repository
    {

        [DataMember(Name = "corporation_id")]
        public string CorpId { get; set; }

        [DataMember(Name = "birthday")]
        public string BDay { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "gender")]
        public string Gender { get; set; }

        [DataMember(Name = "race_id")]
        public string Race { get; set; }

        [DataMember(Name = "bloodline_id")]
        public string Bloodline { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "alliance_id")]
        public string Alliance { get; set; }

        [DataMember(Name = "ancestry_id")]
        public string Ancestry { get; set; }

        [DataMember(Name = "security_status")]
        public string Security { get; set; }

        /*[DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "html_url")]
        public Uri GitHubHomeUrl { get; set; }

        [DataMember(Name = "homepage")]
        public Uri Homepage { get; set; }

        [DataMember(Name = "watchers")]
        public int Watchers { get; set; }

        [DataMember(Name = "pushed_at")]
        private string JsonDate { get; set; }

        [IgnoreDataMember]
        public DateTime LastPush
        {
            get
            {
                return DateTime.ParseExact(JsonDate, "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);
            }
        }
        */

    }
}
