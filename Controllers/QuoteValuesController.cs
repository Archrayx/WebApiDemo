using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Service.Services;
using WebApiDemo.Data;
namespace WebApiDemo.Controllers
{
    [Authorize]
    public class QuoteValuesController : ApiController
    {
        private readonly IQuoteService quoteService;
        
        public QuoteValuesController(IQuoteService quoteService)
        {
            this.quoteService = quoteService;
        }
        [HttpGet]
        public IEnumerable<Quote> GetAll()
        {
            List<Quote> quotes = quoteService.GetAllUsers().ToList();
            return quotes;
        }
        [HttpGet]
        public Quote GetUser(long id)
        {
            return quoteService.GetUser(id);
        }
        [HttpPost]
        public void insertUser([FromBody] Quote user)
        {
            quoteService.insertUser(user);
        }
        [HttpPost]
        public void UpdateUser([FromBody] Quote user)
        {
            quoteService.UpdateUser(user);
        }
        [HttpPost]
        public void DeleteUser(long id)
        {
            quoteService.DeleteUser(id);
        }
    }
}
