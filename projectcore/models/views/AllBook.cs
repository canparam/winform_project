using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace projectcore.models.views
{
  
    public class AllBook
    {
        public int id { get; set; }
        public string title { get; set; }
        public string isbn { get; set; }
        public int quantity { get; set; }
        public int author { get; set; }
        public int publisher { get; set; }
        public int status { get; set; }
        public int count { get; set; }
    }
}
