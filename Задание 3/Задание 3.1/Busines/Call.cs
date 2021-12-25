using System;
using System.Collections.Generic;
using System.Text;
using Задание_3._1.Data_Base;

namespace Задание_3._1
{
    public class Call
    {
        public PortCondition StatusChange { get; set; }
        CollectionPhone collectionPhone = new CollectionPhone();
        public delegate void AccountHandler(object sender, AccountEventArgs e);
        public event AccountHandler Notify;
        public Call(string number)
        {
            Number = number;
            number = collectionPhone.phone;
        }
        public string Number { get; private set; }
        public void Take(string number)
        {
            if (StatusChange == PortCondition.Free)
            {
                StatusChange =PortCondition.Busy;
                Notify?.Invoke(this, new AccountEventArgs($"Соединение с", number));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs("Занят", number));
            }
        }
    }
}
