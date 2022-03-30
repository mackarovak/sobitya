using System;

namespace sobytiya
{
    class Program
    {
        public static void Main(string[] args)
        {
            var eventClass = new EventClass();
            eventClass.OnKeyPressed += OutPutChar;
            eventClass.Run();
        }
        public static void OutPutChar(object sender, char symbol)
        {
            Console.WriteLine(symbol);
        }
    }
}
