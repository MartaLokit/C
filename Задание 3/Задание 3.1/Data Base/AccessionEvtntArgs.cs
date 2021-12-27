using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3._1.Data_Base
{
    public class AccessionEvtntArgs
    {
        public delegate void AccountHandler(object sender, AccessionEvtntArgs e);
        CollectionPhone CollectionPhone = new CollectionPhone();
        public string Message { get; }
        public string NumberPhone { get; }
        public AccessionEvtntArgs(string Mess, string Num)
        {
            Message = Mess;
            NumberPhone = CollectionPhone.phone;
        }
    }
}
