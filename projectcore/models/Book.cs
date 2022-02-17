using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace projectcore.models
{
    [Table("books")]
    public class Book
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string title { get; set; }
        [Required,StringLength(255)]
        public string isbn { get; set; }
        [Required]
        public int publisher { get; set; }
        [Required]
        public int author { get; set; }
        [Required]
        public int genre { get; set; }
        public int status { get; set; }
        [Required]
        public int published_year { get; set; }
        public  string description { get; set; }
        [Required]
        public int quantity { get; set; }
        public  DateTime created_at { get; set; }
        public  DateTime updated_at { get; set; }

    }
}
