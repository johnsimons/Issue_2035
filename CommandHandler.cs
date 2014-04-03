using System;
using NServiceBus;

namespace ClassLibrary1
{
    public abstract class CommandHandler<T> : Handler, IHandleMessages<T>
    {
        protected abstract void OnProcess(T command);

        public virtual void Handle(T message)
        {
            try
            {
                Logger.InfoFormat(@"{0}:{1}", typeof(T).FullName, message.ToString());
                OnProcess(message);
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Failed to Handle {0} Command:{1}", typeof(T).FullName, message.ToString()), ex);
                throw;
            }
        }
    }
}