using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiDemo.Data;
namespace WebApiDemo.Service.Services
{
    public interface IQuoteService
    {
        IEnumerable<Quote> GetAllUsers();
        Quote GetUser(long id);
        void insertUser(Quote user);
        void UpdateUser(long id, Quote user);
        void DeleteUser(long id);
    } 
}