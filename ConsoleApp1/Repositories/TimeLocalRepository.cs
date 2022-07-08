using ConsoleApp1.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositories
{
    internal class TimeLocalRepository : ITimeRepository
    {
        private List<Time> _times;

        public TimeLocalRepository()
        {
            _times = new List<Time>();
        }

        public void Add(Time time)
        {
            _times.Add(time);
        }

        public void Delete(Time time)
        {
            _times.Remove(time);
        }

        public List<Time> Get()
        {
            return _times;
        }

        public Time Get(int id)
        {
            return _times.Where(t => t.Id == id).FirstOrDefault();
        }

        public void Update(Time time)
        {
            throw new NotImplementedException();
        }
    }
}
