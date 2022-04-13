

using AG.Book.Api.Data.Entities;

public class BookConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Book>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Book> builder)
    {
        builder.HasData(new Book[]
        {
            new Book(){Id=1 ,Name = "Otomatik Portakal",Price =20,Created=DateTime.Now,Author="Anthony Burgess"},
            new Book(){Id=2 , Name = "Otomatik Portakal",Price =20,Created=DateTime.Now,Author="Anthony Burgess"},
            new Book(){Id=3 , Name = "Otomatik Portakal",Price =20,Created=DateTime.Now,Author="Anthony Burgess"},
            new Book(){Id=4 , Name = "Otomatik Portakal",Price =20,Created=DateTime.Now,Author="Anthony Burgess"},
            new Book(){Id=5 , Name = "Otomatik Portakal",Price =20,Created=DateTime.Now,Author="Anthony Burgess"},
        });
    }
}



