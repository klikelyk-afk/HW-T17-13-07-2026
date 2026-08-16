namespace CarBuilderApp
{
    public class BmwX1Builder : CarBuilder
    {
        public override void SetName() => Car.Name = "BMW X1";
        public override void SetBodyType() => Car.BodyType = "Універсал";
        public override void SetEnginePower() => Car.EnginePower = 120;
        public override void SetWheelRadius() => Car.WheelRadius = 16;
        public override void SetTransmission() => Car.Transmission = "4 Manual";
    }
}