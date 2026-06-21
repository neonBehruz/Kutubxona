using Kutubxona.Domain.Entities;

namespace Kutubxona.Data.IRepositories;

public interface IBookRepository
{
 
public Task<Book> InsertAsync(Book book);
public Task<Book> ModifyAsync(Book book);
public Task<bool> DropAsync(int id);
public Task<Book> SelectByIdAsync(int id);
public Task<IEnumerable<Book>> SelectAllAsync();
}
