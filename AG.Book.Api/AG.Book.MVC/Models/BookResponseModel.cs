namespace AG.Book.MVC.Models
{
    public class BookResponseModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
        public decimal Price { get; set; }
    }
}
