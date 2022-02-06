using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace projectcore.models
{
    [Table("admin")]
    public class Admin
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string username { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        [StringLength(255)]
        public string password { get; set; }

        public override string ToString()
        {
            return id + "name:" + username;
        }
    }
}
