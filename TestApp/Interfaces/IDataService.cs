using System;
namespace TestApp.Interfaces
{
    public interface IDataService
    {
        //Task<IEnumerable<Book>> GetBooks();
        //Task CreateBook(Book book);
        //Task DeleteBook(int id);
        //Task UpdateBook(Book book);
        Task<string> SignIn(string email, string password);

    }
}

