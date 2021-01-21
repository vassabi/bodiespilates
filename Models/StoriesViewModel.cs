using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class StoriesViewModel
    {
        public List<Story> Stories { get; set; }
        public int MaxItemsToShow { get; set; }
        public bool ShowFullStories { get; set; }
    }
}
