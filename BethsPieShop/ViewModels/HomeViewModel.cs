using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethsPieShop.Models;

namespace BethsPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
