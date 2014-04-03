using NServiceBus;

namespace ClassLibrary1
{
    class Run: IWantToRunWhenBusStartsAndStops
    {
        public IBus Bus { get; set; }

        public void Start()
        {
            Bus.SendLocal(new EventDataMessage {Id = 1});
        }

        public void Stop()
        {
        }
    }
}