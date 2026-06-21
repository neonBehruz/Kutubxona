using Kutubxona.Data.IRepositories;
using Kutubxona.Data.Repository;
using Kutubxona.Domain.Entities;
using Kutubxona.Service.DTOs;
using Kutubxona.Service.Exceptions;
using Kutubxona.Service.Interfaces;

namespace Kutubxona.Service.Services;

public class BookService : IBookService
{
    IBookRepository repository;
    private int _id;

    public BookService()
    {
        repository = new BookRepository();

        var books = repository.SelectAllAsync().Result.ToList();

        if (books.Count == 0)
        {
            _id = 1;
        }
        else
        {
            _id = books.Last().Id + 1;
        }
    }

    public async Task<BookResultDto> CreateAsync(BookCreationDto dto)
    {
        var books = (await repository.SelectAllAsync()).ToList();

        var book = books.FirstOrDefault(x =>
            x.Author == dto.Author &&
            x.Title == dto.Title);

        if (book is not null)
        {
            throw new CustomException("Book already exists", 400);
        }

        var newBook = new Book
        {
            Id = _id++,
            Author = dto.Author,
            Title = dto.Title,
            CreatedAt = DateTime.Now
        };

        await repository.InsertAsync(newBook);

        return new BookResultDto
        {
            Id = newBook.Id,
            Author = newBook.Author,
            Title = newBook.Title
        };
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DropAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<BookResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<BookResultDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Book> InsertAsync(Book book)
    {
        throw new NotImplementedException();
    }

    public Task<Book> ModifyAsync(Book book)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Book>> SelectAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Book> SelectByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<BookResultDto> UpdateAsync(int id, BookCreationDto bookCreationDto)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<BookResultDto>> IBookService.GetAllAsync()
    {
        throw new NotImplementedException();
    }
}