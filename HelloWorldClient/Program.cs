using System;

namespace HelloWorldClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HelloWorldService.HelloWorldServiceClient();
            var helloFromService = client.HelloWorld();
            Console.WriteLine(helloFromService);
        }
    }
}
