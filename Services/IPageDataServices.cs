using NewPortfolioUpdate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPortfolioUpdate.Services
{
    interface IPageDataServices
    {//purpose is to create an outline of what other classes will impliment (contract)
        //create a function;
        List<PageDisplayModel> GetAllData();
        List<PageDisplayModel> SearchData(string searchTerm);
        List<PageDisplayModel> GetDataById(int id);

        int Insert(PageDisplayModel entry);
        int Delete(PageDisplayModel entry);

        int Update(PageDisplayModel entry);

    }
}
