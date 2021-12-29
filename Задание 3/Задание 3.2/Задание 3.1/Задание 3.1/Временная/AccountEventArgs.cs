using System;
using System.Collections.Generic;
using System.Text;
using Задание_3._1.Data_Base;

namespace Задание_3._1.Временная
{
    public class AccountEventArgs
    {
        public string Message { get; }
        public string Phone { get; }
        public AccountEventArgs(string Mess,string Pho)
        {
            Message = Mess;
            Phone = Pho;
        }

    }
}
