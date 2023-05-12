using System;
using Supabase;
using TestApp.Interfaces;

namespace TestApp.Services
{
	public class DataService : IDataService
	{
        public readonly Client _supabaseClient;

        public DataService(Supabase.Client supabaseClient)
        {
            _supabaseClient = supabaseClient;
        }

        //public Client GetClient()
        //{
        //    return _supabaseClient;
        //}

        //public async Task<IEnumerable<Book>> GetBooks()
        //{
        //    var response = await _supabaseClient.From<Book>().Get();
        //    return response.Models.OrderByDescending(b => b.CreatedAt);
        //}
        public async Task<string> SignIn(string email, string password)
        {
            var session = await _supabaseClient.Auth.SignIn(email, password);

            return "correct";
        }

        public async Task<string> SignUp(string email, string password)
        {
            var session = await _supabaseClient.Auth.SignUp(email, password);
            return "correct";
        }
    }
}

