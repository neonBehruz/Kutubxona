using Kutubxona.Service.DTOs;
using Kutubxona.Service.Services;
var service = new BookService();

await service.CreateAsync(new BookCreationDto
{
    Author = "J.K. Rowling",
    Title = "Harry Potter and the Sorcerer's Stone",
    Year = 1997
});