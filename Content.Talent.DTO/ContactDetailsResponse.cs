using System;
using System.Collections.Generic;
using System.Text;

namespace Content.Talent.DTO
{
    public class ContactDetailsResponse
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string primarySkill { get; set; }
        public string personalWebsiteUrl { get; set; }
        public string phoneNumber { get; set; }
        public string location { get; set; }
        public string timeZone { get; set; }
        public string contenltyProtifolioURl { get; set; }
        public string  profilePhoto { get; set; }
        public Guid talent_id { get; set; }
        public bool is_delete { get; set; }
    }
}
