using NewPortfolioUpdate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPortfolioUpdate.Services
{
    interface IShopDataService
    {
        List<shopModel> GetAllProducts();
        List<shopModel> SearchProducts(string searchTerm);
        List<shopModel> GetProductById(int id);
        List<shopModel> GetProductByUnique(string Unique);

        int Insert(shopModel product);
        int Delete(shopModel product);

        int Update(shopModel product);

    }
}
