using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Answer { get; set; }
    }
}
