using System;
using System.Collections.Generic;
using System.Text;
using Задание_3._1.Data_Base;
namespace Задание_3._1.Busines
{
    public class PortCompanion:Station
    {
        public event AccountHandler Notify;
        public PortCompanion(string number)
        {
            Number = number;
        }
        public void Take(string number,string nameSubscriber)
        {
            Number = number;
            if (StatusChange == PortCondition.Free)
            {
                StatusChange = PortCondition.Busy;
                Notify?.Invoke(this, new AccountEventArgs($"Вызов с {nameSubscriber}", number));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs($"Пропущенный от {nameSubscriber}", number));
            }
        }
    }
}
