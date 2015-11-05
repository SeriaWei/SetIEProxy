using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetIEProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            string proxy;
            if (args.Length == 0)
            {
                Console.WriteLine("请输入代理地址，如：127.0.0.1:808：");
                proxy = Console.ReadLine();
            }
            else
            {
                proxy = args[0];
            }
            IEProxySetting.SetProxy(proxy);
        }
    }
}
