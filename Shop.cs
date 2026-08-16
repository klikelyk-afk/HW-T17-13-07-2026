namespace CarBuilderApp
{
    public class Shop
    {
        public Car Construct(CarBuilder builder)
        {
            builder.CreateCar();
            builder.SetName();
            builder.SetBodyType();
            builder.SetEnginePower();
            builder.SetWheelRadius();
            builder.SetTransmission();

            return builder.GetCar();
        }
    }
}