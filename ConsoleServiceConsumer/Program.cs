using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ConsoleServiceConsumer.localhost;

namespace ConsoleServiceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            Console.WriteLine(service.HelloWorld());        
            Console.Read();
        }
    }
}
