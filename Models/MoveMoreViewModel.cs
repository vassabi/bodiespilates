using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class MoveMoreViewModel
    {
        public List<VideoCategory> Categories { get; set; }
        public IEnumerable<IGrouping<string, VideoCategory>> GroupedCategories { get; set; }
        public List<VideoCategory> CategoriesWithVideos { get; set; }
        public List<Video> Videos { get; set; }
        public int? CurrentCategoryId { get; set; }
    }
}
