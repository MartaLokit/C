using System;
using System.Collections.Generic;
using System.Text;
using Задание_3._1.Data_Base;

namespace Задание_3._1.Временная
{
   public  class Station
   {
        PortCompanion portCompanion = new PortCompanion();
        public PortCondition StatusChanges { get; set; }
        public PortCompanion StatusChange { get; set; }
        public void Connect(string phone)
        {
            OnCalling OnCalling = new OnCalling(phone);
            OnCalling.Notify += DisplayMessage;
            if (StatusChanges==PortCondition.Free)//уточнить
            {
                portCompanion.Call(phone);
            }
        }
        public void EndCall(string phone)
        {
            OnCalling OnCalling = new OnCalling(phone);
            OnCalling.Notify -= DisplayMessage;
        }
        public static void DisplayMessage(object sender, AccountEventArgs args)
        {
            Console.WriteLine($"Вызов от :{args.Phone}");
            Console.WriteLine(args.Message);
        }
        public static void DisplayMessages(object sender, AccountEventArgs args)
        {
            Console.WriteLine($"Вызов к:{args.Phone}");
            Console.WriteLine(args.Message);
        }
    }
}

   