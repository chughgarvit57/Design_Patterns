namespace DesignPatterns
{
    public class ElectricSUVFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            return new ElectricSUV();
        }
    }
}
