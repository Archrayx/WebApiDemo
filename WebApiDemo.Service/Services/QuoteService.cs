using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiDemo.repo;
using WebApiDemo.Data;
namespace WebApiDemo.Service.Services
{
    public class QuoteService : IQuoteService
    {
        private IRepo<Quote> quoteRepo;

        public QuoteService(IRepo<Quote> repo)
        {
            this.quoteRepo = repo;
        }
        public IEnumerable<Quote> GetAllUsers()
        {
            return quoteRepo.GetAll();
        }
        public  Quote GetUser(long id)
        {
            return quoteRepo.Get(id);
        }
        public void insertUser(Quote user)
        {
            quoteRepo.Insert(user);
            
        }
        public void UpdateUser(long id, Quote user)
        {
            quoteRepo.Update(id, user);
            
        }

        public void DeleteUser(long id)
        {
            quoteRepo.Delete(id);
            
        }
    }
}