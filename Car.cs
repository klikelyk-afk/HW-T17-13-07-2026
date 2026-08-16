using System;

namespace CarBuilderApp
{
    public class Car
    {
        public string Name { get; set; }
        public string BodyType { get; set; }
        public int EnginePower { get; set; }
        public int WheelRadius { get; set; }
        public string Transmission { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"Корпус: {BodyType}");
            Console.WriteLine($"Двигун: {EnginePower} к.с.");
            Console.WriteLine($"Колеса (R): {WheelRadius}");
            Console.WriteLine($"К.П.П.: {Transmission}\n");
        }
    }
}