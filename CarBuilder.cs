namespace CarBuilderApp
{
    public abstract class CarBuilder
    {
        protected Car Car { get; private set; }

        public void CreateCar()
        {
            Car = new Car();
        }

        public Car GetCar()
        {
            return Car;
        }

        public abstract void SetName();
        public abstract void SetBodyType();
        public abstract void SetEnginePower();
        public abstract void SetWheelRadius();
        public abstract void SetTransmission();
    }
}