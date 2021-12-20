using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3.Busines
{
    class Port:Phone
    {
        public PortState StatusChange { get; set; }
        Predicate<string> predicate;//для сравнения состояния 
        public event EventHandler<StartingCallEventArgs> StartCall;
        public event EventHandler<StartingCallEventArgs> Request;
        public void Ports(object sender, StartingCallEventArgs arg)
        {
            if(StatusChange==PortState.Free)
            {
                StatusChange = PortState.Busy;
                OnStartCall(this, arg);
            }
        }
        protected virtual void OnStartCall(object sender, StartingCallEventArgs arg)
        {
            StartCall?.Invoke(sender, arg);
        }
        protected void OnRequest(object sender, StartingCallEventArgs arg)
        {
            Request?.Invoke(sender, arg);
        }
    }

}

