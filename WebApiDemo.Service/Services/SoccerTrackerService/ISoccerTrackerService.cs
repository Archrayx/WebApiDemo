using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiDemo.Data;
namespace WebApiDemo.Service.Services
{
    public interface ISoccerTrackerService
    {
        IEnumerable<FinalSoccerEdit_> GetAllUsers();
        FinalSoccerEdit_ GetUser(long id);
        void insertUser(FinalSoccerEdit_ user);
        void UpdateUser(long id, FinalSoccerEdit_ user);
        void DeleteUser(long id);
    }
}