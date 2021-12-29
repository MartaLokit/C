using System;
using System.Collections.Generic;
using System.Text;
using Задание_3._1.Data_Base;

namespace Задание_3._1.Временная
{
    public class OnCalling
    {
        CollectionPhone CollectionPhone = new CollectionPhone();
        public PortCondition StatusChange { get; set; }
        public delegate void AccountHandler(object sender, AccountEventArgs e);
        public string Number { get; set; }
        public event AccountHandler Notify;
        public OnCalling(string number)
        {
            Number = number;
        }
        public void Take(string number)
        {
            if (StatusChange == PortCondition.Free)
            {
                StatusChange = PortCondition.Busy;
                Notify?.Invoke(this, new AccountEventArgs($"Вызов с {number} ", number));
            }
            else
            {
                number =CollectionPhone.GetNumberPhone("+375296525014");
                Notify?.Invoke(this, new AccountEventArgs($"Пропущенный {number}", number));
            }
        }
        

    }
}
