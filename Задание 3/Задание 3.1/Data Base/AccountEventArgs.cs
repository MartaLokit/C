using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3._1.Data_Base
{
    public class AccountEventArgs
    {
        CollectionPhone CollectionPhone = new CollectionPhone();
        public string Message{get;}
        public string Number { get; }
        public AccountEventArgs(string Mess, string Num)
        {
            Message = Mess;
            Number = CollectionPhone.phone;
        }
    }
}
