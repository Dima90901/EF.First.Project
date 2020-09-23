using EF.First.Project.DAL.Contex;
using EF.First.Project.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.BLL.Services
{
    public class FirstBLLServiceCars : IDisposable
    {
        private readonly Model1 db = new Model1();
        public IEnumerable<MyFirsModelCars> GetAllCars()
        {
            return db.MyFirstCars;
        }
        public void AddCars ()
        {
            MyFirsModelCars cars = new MyFirsModelCars
            {
                Id = 1,
                Name = "Bently"
            };
            db.MyFirstCars.Add(cars);
            db.SaveChanges();
        }
        public void Dispose ()
        {
            db.Dispose();
        }
    }
}
