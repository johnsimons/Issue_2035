using NServiceBus.ObjectBuilder;

namespace ClassLibrary1
{
    public class EventDataMessageHandler : CommandHandler<EventDataMessage>
    {
        public IBuilder Builder { get; set; }
        public IClassBuilder ClassBuilder { get; set; }

        protected override void OnProcess(EventDataMessage message)
        {
            var order = (IDemo)ClassBuilder.Build(typeof (Demo));
            var order2 = Builder.Build<IDemo>();
            order.Initialise(message.Id);
            order2.Initialise(message.Id);
        }
    }
}