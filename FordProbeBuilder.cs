namespace CarBuilderApp
{
    public class FordProbeBuilder : CarBuilder
    {
        public override void SetName() => Car.Name = "Ford Probe";
        public override void SetBodyType() => Car.BodyType = "Купе";
        public override void SetEnginePower() => Car.EnginePower = 160;
        public override void SetWheelRadius() => Car.WheelRadius = 14;
        public override void SetTransmission() => Car.Transmission = "4 Auto";
    }
}