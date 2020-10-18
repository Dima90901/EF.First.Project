using System.Collections.Generic;

namespace EF.First.Project.BLL.Interfaces
{
    public interface IBLLService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        bool Add(T value);
        bool Edit(T value);
        bool Delete(int id);
        void Dispose();
    }
}
