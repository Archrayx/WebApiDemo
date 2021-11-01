using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiDemo.repo;
using WebApiDemo.Data;
namespace WebApiDemo.Service.Services
{
    public class SoccerTrackerService : ISoccerTrackerService
    {
        private IRepo<FinalSoccerEdit_> quoteRepo;

        public SoccerTrackerService(IRepo<FinalSoccerEdit_> repo)
        {
            this.quoteRepo = repo;
        }
        public IEnumerable<FinalSoccerEdit_> GetAllUsers()
        {
            return quoteRepo.GetAll();
        }
        public  FinalSoccerEdit_ GetUser(long id)
        {
            return quoteRepo.Get(id);
        }
        public void insertUser(FinalSoccerEdit_ user)
        {
            quoteRepo.Insert(user);
            
        }
        public void UpdateUser(long id, FinalSoccerEdit_ user)
        {
            quoteRepo.Update(id, user);
            
        }

        public void DeleteUser(long id)
        {
            quoteRepo.Delete(id);
            
        }
    }
}