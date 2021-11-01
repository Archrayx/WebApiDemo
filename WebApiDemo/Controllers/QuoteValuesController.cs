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
    //[Authorize]
    public class QuoteValuesController : ApiController
    {
        private readonly IQuoteService quoteService;
        
        public QuoteValuesController(IQuoteService quoteService)
        {

            this.quoteService = quoteService;
        }
        [HttpGet]
        [Route("api/allquotes")]
        public IEnumerable<Quote> GetAll()
        {
            List<Quote> quotes = quoteService.GetAllUsers().ToList();
            return quotes;
        }
        [HttpGet]
        [Route("api/Quote/{id}")]
        public Quote GetUser(long id)
        {
            return quoteService.GetUser(id);
        }
        [HttpPost]
        [Route("api/addquote")]
        public void insertUser([FromBody] Quote user)
        {
            quoteService.insertUser(user);
        }
        [HttpPut]
        [Route("api/updatequote/{id}")]
        public void UpdateUser(long id, [FromBody] Quote user)
        {
            quoteService.UpdateUser(id, user);
        }

        [HttpDelete]
        [Route("api/deletequote/{id}")]
        public void DeleteUser(long id)
        {
            
            quoteService.DeleteUser(id);
        }
    }
}
