using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace projectcore.models
{ 

    [Table("issua_list")]
    public class Issues_list
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int issue_id { get; set; }
        [Required]
        public int book_id { get; set; }
        public int status { get; set; }

    }
}
