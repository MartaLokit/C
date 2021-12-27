using System;
using System.Collections.Generic;
using System.Text;
using Задание_3._1.Data_Base;

namespace Задание_3._1.Busines
{
   public class EventReg
    {
        public delegate void RegEvent(object sender, RegistrationEventArgs e);
        public string Message { get; }
        public event RegEvent Notify;
    }
}
