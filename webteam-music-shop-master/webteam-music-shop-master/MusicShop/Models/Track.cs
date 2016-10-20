using System;

namespace MusicShop.Models
{
    public class Track
    {
        public int Number { get; set; }
        public string SongTitle { get; set; }
        public TimeSpan Length { get; set; }
    }
}