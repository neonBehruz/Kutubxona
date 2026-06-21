namespace Kutubxona.Service.DTOs;

public class BookResultDto
{
    public int Id { get; set; }
    public string Author { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int Year { get; set; }
}