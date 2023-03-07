using System.ComponentModel.DataAnnotations;

namespace Assignment3_SP2023_rggrant1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [Url]
        public string? ImbdLink { get; set; }
        public string? Genre { get; set; }
        public int ReleaseYear { get; set; }
        public byte[]? MoviePoster { get; set; }

    }
}
