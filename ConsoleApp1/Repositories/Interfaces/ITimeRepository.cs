using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositories.Interfaces
{
    public interface ITimeRepository
    {
        void Add(Time time);
        List<Time> Get();
        Time Get(int id);
        void Update(Time time);
        void Delete(Time time);
    }
}
