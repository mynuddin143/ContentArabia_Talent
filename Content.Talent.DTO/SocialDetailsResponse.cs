using System;
using System.Collections.Generic;
using System.Text;

namespace Content.Talent.DTO
{
    public class SocialDetailsResponse
    {
        public int id { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string linkedin { get; set; }
        public string tumblr { get; set; }
        public string instagram { get; set; }
        public string google { get; set; }
        
        public Guid talent_id { get; set; }
        public bool is_delete { get; set; }
    }
}
