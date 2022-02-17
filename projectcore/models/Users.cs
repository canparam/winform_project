using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectcore.models
{
    [Table("users")]

    public class Users
    {
        [Key]
        public int id { get; set; }
        [Required,StringLength(255)]
        public string fullname { get; set; }
        [Required]
        public int gender { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public int status { get; set; }


        public override string ToString()
        {
            return "id: " + id + " name: " + fullname;
        }
    }
}
