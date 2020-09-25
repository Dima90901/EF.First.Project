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
            FirstBLLService db = new FirstBLLService();
            db.AddCars();
            var cars = db.GetAllCars();
            foreach (var item in cars)
            {
                System.Console.WriteLine(item.GroupId + " - " + item.GroupName);
            }
            System.Console.ReadKey();
        }
    }
}
