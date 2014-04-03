using NServiceBus;

namespace ClassLibrary1
{
    public class EventDataMessage:ICommand
    {
        public int Id { get; set; }
    }
}