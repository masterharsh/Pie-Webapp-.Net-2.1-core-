using System;
using System.Collections.Generic;
namespace myFirstApp.Models
{
    public interface IPieInterface
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}
