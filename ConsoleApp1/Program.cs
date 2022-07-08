// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ConsoleApp1;
using ConsoleApp1.Repositories;
using ConsoleApp1.Repositories.Interfaces;

public class Program
{



    public static void Main(string[] args)
    {
        //ITimeRepository _timeRepository = new TimeLocalRepository();
        ITimeRepository _timeRepository = new TimeSqlServerRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FutebolDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        Time time1 = new Time()
        {
            Id = 1,
            Nome = "Flamengo"
        };

        Time time2 = new Time()
        {
            Id = 2,
            Nome = "Vasco"
        };

        _timeRepository.Add(time1);
        _timeRepository.Add(time2);

        var times = _timeRepository.Get();

        foreach (var time in times)
        {
            Console.WriteLine(time.Id + time.Nome);
        }
    }
}