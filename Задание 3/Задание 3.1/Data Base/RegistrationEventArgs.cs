using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3._1.Data_Base
{
    public class RegistrationEventArgs
    {
        public string Message { get; }
        public RegistrationEventArgs(string Mess)
        {
            Message = Mess;
        }
    }
}
