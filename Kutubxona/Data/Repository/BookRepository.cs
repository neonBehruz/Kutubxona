using Kutubxona.Data.IRepositories;
using Kutubxona.Domain.Configuration;
using Kutubxona.Domain.Entities;
using Kutubxona.Service.Services;
using Newtonsoft.Json;

namespace Kutubxona.Data.Repository;

public class BookRepository : IBookRepository
{

    private string path;
public BookRepository()
    {
        this.path=BookPathHelper.BookPath;
    }
public async Task<Book> DropAsync(int id)
{
        throw new NotImplementedException();
}
public async Task<Book> InsertAsync(Book book)
    {
        var json = JsonConvert.SerializeObject(book, Formatting.Indented);
        File.WriteAllText(path, json);
        return book;
    }
    public async Task<Book> ModifyAsync(Book book)
    {
        throw new NotImplementedException();
    }
    public async Task<IEnumerable<Book>> SelectAllAsync()
    {
        var text = await File.ReadAllTextAsync(path);
        var books = JsonConvert.DeserializeObject<IEnumerable<Book>>(text);
        return books;
    }

    public Task<Book> SelectByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task<bool> IBookRepository.DropAsync(int id)
    {
        throw new NotImplementedException();
    }
}