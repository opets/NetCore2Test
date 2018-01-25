using System;
using ClassLibrary1;
using ClassLibrary2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class2.Message);
			//Class2.ZipTest();
			Class2.ZipCompressTest();

		}
    }
}