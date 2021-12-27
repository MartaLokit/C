using System;
using System.Collections.Generic;
using System.Text;
using Задание_3._1.Data_Base;

namespace Задание_3._1.Busines
{
    public class PortSubscriber:Station
    {     
        public event AccountHandler Notify;
        public PortSubscriber(string number)
        {
            Number = number;
        }
      
        public void Take(string number)
        {
            Number = number;
            if (StatusChange == PortCondition.Free)
            {
                StatusChange = PortCondition.Busy;
                Notify?.Invoke(this, new AccountEventArgs($"Соединение с", number));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs("Занят", number));
            }
        }
    }
}
