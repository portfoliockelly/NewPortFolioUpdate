using NewPortfolioUpdate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPortfolioUpdate.Services
{
    public class HardCodedSampleDataRepos : IPageDataServices 
    {
        List<PageDisplayModel> displayList = new List<PageDisplayModel>();// moving this outside of the function makes it global so each function can read.
        public int Delete(PageDisplayModel entry)
        {
            throw new NotImplementedException();
        }

        public List<PageDisplayModel> GetAllData()
        {
            if(displayList.Count ==0)
            {
                displayList.Add(new PageDisplayModel { Id = 1, Name = "Joey", Date = new DateTime(2008, 4, 10, 6, 30, 0), Description = "Appointment for something" });
                displayList.Add(new PageDisplayModel { Id = 2, Name = "Joe boogy", Date = new DateTime(2021, 4, 1, 8, 30, 0), Description = "Appointment for something new" });
                displayList.Add(new PageDisplayModel { Id = 3, Name = "Zoe", Date = new DateTime(2023, 3, 12, 5, 30, 0), Description = "Appointment for disapointment" });
            }
            return displayList;
        }
       // public List<WelcomeModel> GetAllInfo()
       // {
       //     displayList.Add(new PageDisplayModel { About = "", DevelopmentSummery = "", Future = "" });
       // }


        public List<PageDisplayModel> GetDataById(int id)
        {
            throw new NotImplementedException();
        }


        public int Insert(PageDisplayModel entry)
        {
            throw new NotImplementedException();
        }

        public List<PageDisplayModel> SearchData(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public List<PageDisplayModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(PageDisplayModel entry)
        {
            throw new NotImplementedException();
        }
    }
}
