namespace FactoryMethod
{
    abstract class VehicleCreator
    {
        public abstract IVehicle createVehicle();
        public void moveVehicle()
        {
            IVehicle vehicle = createVehicle();
            vehicle.move();
        }
    }
}
