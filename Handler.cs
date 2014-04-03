using System;
using NServiceBus;
using NServiceBus.Logging;

namespace ClassLibrary1
{
    public abstract class Handler
    {
        protected static readonly ILog Logger = LogManager.GetLogger(AppDomain.CurrentDomain.FriendlyName);

        public IBus Bus { get; set; }
    }
}