namespace DesignPatterns
{
    public class PetrolSUVFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            return new PetrolSUV();
        }
    }
}
