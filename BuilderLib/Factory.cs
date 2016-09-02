namespace BuilderLib
{
    public class Factory
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
            vehicleBuilder.BuildColour();
        }
    }
}