using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewPortfolioUpdate.Models
{
    public class shopModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DisplayName("Cost")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DisplayName("Item Description")]
        public string Description { get; set; }

      

    }
}
