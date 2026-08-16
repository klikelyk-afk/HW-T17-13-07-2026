using System;

namespace CarBuilderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Shop shop = new Shop();

            CarBuilder lanosBuilder = new DaewooLanosBuilder();
            Car lanos = shop.Construct(lanosBuilder);
            lanos.ShowInfo();

            CarBuilder probeBuilder = new FordProbeBuilder();
            Car probe = shop.Construct(probeBuilder);
            probe.ShowInfo();

            CarBuilder bmwBuilder = new BmwX1Builder();
            Car bmw = shop.Construct(bmwBuilder);
            bmw.ShowInfo();

            CarBuilder getzBuilder = new HyundaiGetzBuilder();
            Car getz = shop.Construct(getzBuilder);
            getz.ShowInfo();

            Console.ReadKey();
        }
    }
}