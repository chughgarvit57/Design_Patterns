namespace DesignPatterns
{
    public class RemoteControl
    {
        protected IDevice device;
        public RemoteControl(IDevice device)
        {
            this.device = device;
        }
        public void PressPower()
        {
            device.TurnOn();
        }
    }
}
