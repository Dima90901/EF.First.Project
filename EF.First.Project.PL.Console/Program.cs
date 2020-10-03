using EF.First.Project.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.PL.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BLLService db = new BLLService();
            db.AddCars();
            var cars = db.GetAllGroups();
            foreach (var item in cars)
            {
                System.Console.WriteLine(item.Id + " - " + item.GroupName);
            }
            System.Console.ReadKey();
        }
    }
}
