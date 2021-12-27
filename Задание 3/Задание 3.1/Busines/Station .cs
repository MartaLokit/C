using System;
using System.Collections.Generic;
using System.Text;
using Задание_3._1.Data_Base;

namespace Задание_3._1.Busines
{
    public class Station
    {
        public PortCondition StatusChange { get; set; }
        public delegate void AccountHandler(object sender, AccountEventArgs e);
        public string Number { get; set; }
    }
}
