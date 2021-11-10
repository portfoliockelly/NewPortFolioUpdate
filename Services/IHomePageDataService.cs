using NewPortfolioUpdate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPortfolioUpdate.Services
{
    interface IHomePageDataService
    {//purpose is to create an outline of what other classes will impliment (contract)
        //create a function;
        List<WelcomeModel> GetAllData();
       
        
        List<WelcomeModel> SearchData(string searchTerm);
        List<WelcomeModel> GetDataById(int id);

        int Insert(WelcomeModel entry);
        int Delete(WelcomeModel entry);

        int Update(WelcomeModel entry);
    }
}
