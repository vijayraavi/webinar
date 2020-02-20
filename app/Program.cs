using System;
using App.Shared;
using Console = Colorful.Console;

namespace App
{
    public class Program
    {        
        public static void Main(string[] args) => 
            Console.WriteAscii(
                new MessengerService("Webinar").GetMessage()
            );
    }
}