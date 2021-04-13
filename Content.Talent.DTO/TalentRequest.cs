using System;
using System.Collections.Generic;
using System.Text;

namespace Content.Talent.DTO
{
    public class TalentRequest
    {
        public string talent_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string emailaddress { get; set; }
        public string primary_skill { get; set; }
        public string personal_website { get; set; }
        public string phone_number { get; set; }
        public string location { get; set; }
        public string timezone { get; set; }
        public string contenlyprofileUrl { get; set; }
        public string profile_photo { get; set; }

        public string facebook { get; set; }
        public string twitter { get; set; }
        public string linkedin { get; set; }
        public string tumblr { get; set; }
        public string instagram { get; set; }
        public string google { get; set; }

        public string title { get; set; }
        public string bio { get; set; }
        public string fluentLanguages { get; set; }

        public string name { get; set; }
        public string publishedon { get; set; }
        public string createdon { get; set; }
        public string modifiedon { get; set; }
        public string url { get; set; }
        public string fields { get; set; }
        public string covers { get; set; }
        public string maturecontent { get; set; }
        public string owners { get; set; }
        public string stats { get; set; }
    }
}
