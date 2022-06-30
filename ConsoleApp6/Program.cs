using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    //public class Car
    //{
    //    public int Name { get; set; }
    //    public static DateTime GlobalDateTime;
    //    static Car()
    //    {
    //        GlobalDateTime = DateTime.Now;
    //        Console.WriteLine($"Car created {GlobalDateTime}");
    //        //throw new Exception("Error");
    //        Console.WriteLine("Static Constructor");
    //    }

    //    public Car()
    //    {
    //        Thread.Sleep(1000);
    //        Console.WriteLine(DateTime.Now);
    //        Console.WriteLine("Default Constructor");
    //    }
    //}
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Car car = new Car();
    //        Car car2 = new Car();
    //        Car car3 = new Car();

    //    }
    //}


    //class Car
    //{
    //    public static string Factory { get; set; } = "Stutgard Car Factory";
    //    public static int global_id = 0;
    //    public int Id { get; set; }
    //    public string Model { get; set; }
    //    public double Engine { get; set; }
    //    public Car()
    //    {
    //        Id = ++global_id;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Console.WriteLine(Car.Factory);
    //        Car[] cars =
    //        {
    //            new Car(),
    //            new Car(),
    //            new Car(),

    //        };
    //        foreach (var item in cars)
    //        {
    //            Console.WriteLine(item.Id);
    //        }

    //    }
    //}

    //public class NetworkSettings
    //{
    //    public static int LocalPort { get; set; } = 27001;
    //    public static string LocalHost { get; set; } = "127.0.0.1";

    //    public static string GetHostName()
    //    {
    //        return LocalHost + ":" + LocalPort.ToString();
    //    }
    //}
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter program port");
    //        int port = int.Parse(Console.ReadLine());


    //        string ip = NetworkSettings.LocalHost;

    //        if (port == NetworkSettings.LocalPort)
    //        {

    //        }


    //    }
    //}



    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount()
            {
                No = 1,
                BankName = "Kapital Bank"
            };
            account.CallUpdate();
            account.Show();
        }
    }
}
