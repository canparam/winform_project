using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace projectcore.models
{
    [Table("publishers")]
    public class Publishers
    {
        [Key]
        public int id { get; set; }
        [Required,StringLength(255)]
        public string name { get; set; }
        public int status { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
