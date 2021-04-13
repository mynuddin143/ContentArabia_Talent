using System;
using System.Collections.Generic;
using System.Text;

namespace Content.Talent.DTO
{
    public class BioDetailsResponse
    {
        public int id { get; set; }
        public string bio { get; set; }
        public string title { get; set; }
        public string fluentLanguage { get; set; }
        public Guid talent_id { get; set; }
        public bool is_delete { get; set; }
    }
}
