using System;
using System.Collections.Generic;
using System.Text;

namespace Content.Talent.DTO
{
    public class ProjectDetailsResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string publishedOn { get; set; }
        public string createdOn { get; set; }
        public string modifiedOn { get; set; }
        public string url { get; set; }
        public string fields { get; set; }
        public string covers { get; set; }
        public string owners { get; set; }
        public string stats { get; set; }
        public string matureContent { get; set; }

        public Guid talent_id { get; set; }
        public bool is_delete { get; set; }
    }
}
