using System;

namespace FactoryMethod
{
    class CarCreator : VehicleCreator
    {
        public override IVehicle createVehicle()
        {
            return new Car();
        }
    }

    class ShipCreator : VehicleCreator
    {
        public override IVehicle createVehicle()
        {
            return new Ship();
        }
    }
}
