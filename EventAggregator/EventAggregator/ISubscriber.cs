using System;
using System.Collections.Generic;
using System.Text;

namespace EventAggregator
{
    public interface ISubscriber<TEventType>
    {
        void OnEventHandler(TEventType e);
    }
}
