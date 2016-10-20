using System.Collections.Generic;

namespace MusicShop.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string CoverUrl { get; set; }
        public List<Track> Tracks { get; set; }
    }
}