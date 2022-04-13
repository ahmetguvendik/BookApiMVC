using AG.Book.Api.Data.Entities;
using AG.Book.Api.Models;

public interface IBook
{
    public Task<List<Book>> GetAll();
    public Task<Book> GetById(int id);
    public Task AddBook(CreateBookModel book);
    public Task UpdateBookAsync(UpdateBookModel book, int id);
    public Task DeleteBookAsync(int id);
}

