namespace PatternApp
{
    public abstract class VehicleBuilder
    {
        public Vehicle vehicle;

        public Vehicle Vehicle => vehicle;

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
        public abstract void BuildColour();
    }
}