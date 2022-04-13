using System.ComponentModel.DataAnnotations.Schema;

namespace AG.Book.Api.Data.Entities
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
    }
}
