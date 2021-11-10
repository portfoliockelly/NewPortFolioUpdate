using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NewPortfolioUpdate.Models
{
    public class PageDisplayModel
    {

        [DisplayName("Patient Id")]
        public int Id { get; set; }
        [DisplayName("Patient Name")]
        public string Name { get; set; }
        [DisplayName("Appointment Date/Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dddd, dd MMMM yyyy}")]
        public DateTime Date { get; set; }
        [DisplayName("Reason for Appointment")]
        public string Description { get; set; }


    }
}
