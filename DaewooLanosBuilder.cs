namespace CarBuilderApp
{
    public class DaewooLanosBuilder : CarBuilder
    {
        public override void SetName() => Car.Name = "Daewoo Lanos";
        public override void SetBodyType() => Car.BodyType = "Седан";
        public override void SetEnginePower() => Car.EnginePower = 98;
        public override void SetWheelRadius() => Car.WheelRadius = 13;
        public override void SetTransmission() => Car.Transmission = "5 Manual";
    }
}