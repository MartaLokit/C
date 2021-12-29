using System;
using System.Collections.Generic;
using System.Text;
using Задание_3._1.Data_Base;

namespace Задание_3._1.Временная
{
     public class PortCompanion:Station
     {   
        public void Call(string numberPhone)
        {
            if (StatusChanges == PortCondition.Free)
            {
                StatusChanges = PortCondition.Busy;
                OnCalling OnCalling = new OnCalling(numberPhone);
                OnCalling.Notify += Station.DisplayMessage;
            }
        }
     }
}
