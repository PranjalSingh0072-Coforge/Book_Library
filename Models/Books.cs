using System.ComponentModel.DataAnnotations;

namespace Book_Library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; } // Unique identifier
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
    }
}