namespace AG.Book.MVC.Models
{
    public class UpdateBookModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
    }
}
