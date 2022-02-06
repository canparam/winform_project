using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace projectcore.models
{
    [Table("issues")]
    public class Issues
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int user_id { get; set; }
        [Required]
        public int admin_id { get; set; }
        [Required]
        public int status { get; set; }
        [Required]
        public DateTime issue_date { get; set; }
        [Required]
        public DateTime expiry_date { get; set; }
        [Required]

        public DateTime return_date { get; set; }
    }
}
