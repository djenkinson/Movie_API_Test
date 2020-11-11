using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_API.Models
{
    public class MovieStats
    {
        public string movieId { get; set; }
        public string title { get; set; }
        public int averageWatchDurationS { get; set; }
        public int watches { get; set;}
        public int releaseYear { get; set; }
    }
}
