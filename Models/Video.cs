using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Video
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string VideoUrl { get; set; }

        public int VideoCategoryId { get; set; }
    }
}
