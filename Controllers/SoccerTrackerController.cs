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
    public class SoccerTrackerController : ApiController
    {
        private readonly ISoccerTrackerService soccerTrackerService;

        public SoccerTrackerController(ISoccerTrackerService soccerTrackerService)
        {

            this.soccerTrackerService = soccerTrackerService;
        }

        [HttpGet]
        [Route("api/allsoccerTrackers")]
        public IEnumerable<FinalSoccerEdit_> GetAll()
        {
            List<FinalSoccerEdit_> soccerTrackers = soccerTrackerService.GetAllUsers().ToList();
            return soccerTrackers;
        }
        [HttpGet]
        [Route("api/SoccerTracker/{id}")]
        public FinalSoccerEdit_ GetUser(long id)
        {
            return soccerTrackerService.GetUser(id);
        }
        [HttpPost]
        [Route("api/addsoccerTracker")]
        public void insertUser([FromBody] FinalSoccerEdit_ user)
        {

            //FinalSoccerEdit_ user2 = ReverseUser(user);
            soccerTrackerService.insertUser(user);
            //soccerTrackerService.insertUser(user2);
        }
        [HttpPut]
        [Route("api/updatesoccerTracker/{id}")]
        public void UpdateUser(long id, [FromBody] FinalSoccerEdit_ user)
        {
            FinalSoccerEdit_ user2 = ReverseUser(user);
            soccerTrackerService.UpdateUser(id, user);
            //soccerTrackerService.UpdateUser(id+1,user2);
        }

        [HttpDelete]
        [Route("api/deletesoccerTracker/{id}")]
        public void DeleteUser(long id)
        {

            soccerTrackerService.DeleteUser(id);
            //soccerTrackerService.DeleteUser(id);
        }

        public FinalSoccerEdit_ ReverseUser(FinalSoccerEdit_ user)
        {
            string tempVal = user.Team_1;
            user.Team_1 = user.Team_2;
            user.Team_2 = tempVal;
            return user;
        }
    }
}