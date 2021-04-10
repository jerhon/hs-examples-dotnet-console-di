namespace Honlsoft.Examples.DependencyInjection
{
    public class Driver
    {
        private IVehicle _vehicle;
        
        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        
        public void GoSomewhere()
        {
            _vehicle.Drive();    
        }
    }
}