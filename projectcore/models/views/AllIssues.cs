using System;
using System.Collections.Generic;
using System.Text;

namespace projectcore.models.views
{
    public class AllIssues
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public int user_id { get; set; }
        public DateTime? expiry_date { get; set; }
        public DateTime? issue_date { get; set; }
        public DateTime? return_date { get; set; }
        public int status { get; set; }
        public string username { get; set; }
        public int count { get; set; }
        public string title { get; set; }
        public string email { get; set; }
    }
}
