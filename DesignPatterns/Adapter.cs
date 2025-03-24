namespace DesignPatterns
{
    public class Adapter : ITarget
    {
        private OldSystem oldSystem = new();
        public void Connect()
        {
            oldSystem.LegacyConnect();
        }
    }
}
