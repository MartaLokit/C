using System;
using System.Collections.Generic;
using System.Text;
namespace Задание_3._1.Data_Base
{
    public class AccountEventArgs
    {
        CollectionPhone CollectionPhone = new CollectionPhone();
        public string Message{get;}
        public string NameSubscriber { get; }
        public AccountEventArgs(string Mess, string Num)
        {
            Message = Mess;
<<<<<<< HEAD
            NameSubscriber = CollectionPhone.phone;
=======
            Number = CollectionPhone.phone;
>>>>>>> d345db77acd860550de3e6c194646e702bbf6792
        }
    }
}
