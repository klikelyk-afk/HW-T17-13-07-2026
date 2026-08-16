namespace CarBuilderApp
{
    public class HyundaiGetzBuilder : CarBuilder
    {
        public override void SetName() => Car.Name = "Hyundai Getz";
        public override void SetBodyType() => Car.BodyType = "Хетчбек";
        public override void SetEnginePower() => Car.EnginePower = 66;
        public override void SetWheelRadius() => Car.WheelRadius = 13;
        public override void SetTransmission() => Car.Transmission = "4 auto";
    }
}