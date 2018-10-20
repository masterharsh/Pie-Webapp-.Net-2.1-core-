using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myFirstApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myFirstApp.ViewModels
{
    public class HomeViewModel : Controller
    {
        public List<Pie> Pies { get; set; }
        public string Title { get; set; }
    }
}
