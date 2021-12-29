using System;
using System.Collections.Generic;
using System.Text;
using Задание_3._1.Data_Base;

namespace Задание_3._1.Временная
{
    public class Phone
    {
        CollectionPhone colection = new CollectionPhone();
        public Phone(string Name)
        {
            Phones = colection.GetNumberPhone(Name);
        }
        public string Phones { get; set; }
        public void PhoneSubscriber(string PhoneSubscriber)
        {
             OnCalling OnCalling = new OnCalling(PhoneSubscriber);
             colection.GetNumberPhone(PhoneSubscriber);
             OnCalling.Take(Phones);
             OnCalling.Notify += Station.DisplayMessage;
        }
        public void PhoneCompanion(string PhoneCompanion)
        {
            OnCalling OnCalling = new OnCalling(PhoneCompanion);
            OnCalling.Notify += Station.DisplayMessage;
            colection.GetNumberPhone(PhoneCompanion);
            OnCalling.Take(Phones);        
        }
       
       
    }
}
