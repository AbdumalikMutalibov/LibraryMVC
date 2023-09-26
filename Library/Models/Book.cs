using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public double Price { get; set; }
    }
}
