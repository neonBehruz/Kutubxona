using Kutubxona.Data.IRepositories;
using Kutubxona.Domain.Entities;

namespace Kutubxona.Data.Repository;

public class BookRepository : IBookRepository
{
    public Task<Book> InsertAsync(Book book)
}
