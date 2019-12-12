using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise5 : IExercise5
    {
       
        public object Method1(string str, int i)
        {
            //           List myStrings = new List<string>;
            // not done, tried implementing tests instead
            IPHostEntry ipHostInfo = Dns.GetHostEntry("myhost.com");
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            Socket client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            // not done
            return string.Empty;
        }
    }
}