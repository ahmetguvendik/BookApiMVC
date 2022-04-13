
using AG.Book.Api.Data.Entities;
using AG.Book.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;

public class BookRepository : IBook
{
    private readonly BookContext _context;
    public BookRepository(BookContext context)
    {
        _context = context;
    }

    public async Task AddBook(CreateBookModel book)
    {
        var books = _context.Books.SingleOrDefault(X => X.Name == book.Name);
        if (books == null)
        {
            var bookMapper = new Book();
            bookMapper.Author = book.Author;
            bookMapper.Name = book.Name;
            bookMapper.Price = book.Price;
            await _context.Books.AddAsync(bookMapper);
            await _context.SaveChangesAsync();
        }

    }

    public Task<List<Book>> GetAll()
    {
        return _context.Books.ToListAsync();

    }

    public async Task<Book> GetById(int id)
    {
        // var data = await _context.Books.FindAsync(id);
        var bookFind = _context.Books.SingleOrDefault(book => book.Id == id);
        if (bookFind == null)
        {
            return null;
        }
        return bookFind;
    }

    public async Task UpdateBookAsync(UpdateBookModel book, int id)
    {
        var books = await _context.Books.FindAsync(id);
        if (books != null)
        {
            books.Price = book.Price != default ? book.Price : books.Price;
            books.Name = book.Name != default ? book.Name : books.Name;
            books.Author = book.Author != default ? book.Author : books.Author;
        }
        await _context.SaveChangesAsync();
    }

    public async Task DeleteBookAsync(int id)
    {
        var deleteBook = await _context.Books.FindAsync(id);
        _context.Books.Remove(deleteBook);
        await _context.SaveChangesAsync();
    }

    //public void UpdateBook(Data.Entities.Book book)
    //{


    //}
}

