using System;

namespace Honlsoft.Examples.DependencyInjection
{
    public class MiniVan : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You are driving a mini van!");
        }
    }
}