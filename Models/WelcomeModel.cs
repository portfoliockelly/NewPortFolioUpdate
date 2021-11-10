using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NewPortfolioUpdate.Models
{
    public class WelcomeModel
    {
        public string id { get; set; }
        public string idTwo { get; set; }
        public string islogo { get; set; }

        public string Title { get; set; }

        public string LineOne { get; set; }

        public string LineTwo { get; set; }

        public string LineThree { get; set; }

        public string Video { get; set; }
        
        public string CardImage { get; set; }
        public string Image { get; set; }
        public string Game { get; set; }

        public string logo { get; set; }

        public string button { get; set; }

        
        [DisplayName("About Me")]
        public string About { get; set; }
        [DisplayName("Development Summery")]
        public string DevelopmentSummery { get; set; }
        [DisplayName("Future")]
        public string Future { get; set; }
    }
}
