using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Story
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string ClientName { get; set; }

        [Required]
        [MaxLength(1500)]
        public string ShortStory { get; set; }

        [Required]
        public string FullStory { get; set; }
    }
}
