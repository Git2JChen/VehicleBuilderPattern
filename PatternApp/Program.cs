using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder vehicleBuilder;
            var factory = new Factory();

            vehicleBuilder = new ScooterBuilder();
            factory.Construct(vehicleBuilder);
            vehicleBuilder.vehicle.Show();

            vehicleBuilder = new MotorCycleBuilder();
            factory.Construct(vehicleBuilder);
            vehicleBuilder.vehicle.Show();

            vehicleBuilder = new CarVehicleBuilder();
            factory.Construct(vehicleBuilder);
            vehicleBuilder.vehicle.Show();

            Console.ReadKey();
        }
    }
}
