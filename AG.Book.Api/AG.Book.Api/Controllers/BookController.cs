using AG.Book.Api.Data.Entities;
using AG.Book.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IBook _bookRepository;
    public BookController(IBook bookRepository)
    {
        _bookRepository = bookRepository;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var book = await _bookRepository.GetAll();
        if (book == null)
        {
            return NotFound();
        }
        return Ok(book);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var book = await _bookRepository.GetById(id);
        return Ok(book);
    }

    [HttpPost]
    public ActionResult<Book> Create(CreateBookModel book)
    {
        _bookRepository.AddBook(book);
        return Ok();
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateAsync(UpdateBookModel book, int id)
    {

        var uptadeBook = await _bookRepository.GetById(id);
        if (uptadeBook != null)
        {
            await _bookRepository.UpdateBookAsync(book, id);
        }
        return Ok();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        await _bookRepository.DeleteBookAsync(id);
        return Ok();

    }
}

