using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BancoLocal
    {
        List<Time> times = new List<Time>();

        public void Inserir(Time time)
        {
            times.Add(time);
        }

        public List<Time> Get()
        {
            return times;
        }
    }
}
