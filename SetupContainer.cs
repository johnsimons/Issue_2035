using NServiceBus;

namespace ClassLibrary1
{
    public class SetupContainer : INeedInitialization
    {
        public void Init()
        {
            Configure.Component<NServiceBusClassBuilder>(DependencyLifecycle.SingleInstance);
            Configure.Component<Demo>(DependencyLifecycle.InstancePerCall);
            Configure.Component<OrderRepository>(DependencyLifecycle.InstancePerUnitOfWork);
        }
    }
}