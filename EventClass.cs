using System;
using System.Collections.Generic;
using System.Text;

namespace sobytiya
{
    public class EventClass
    {
        public event EventHandler<char> OnKeyPressed;

        public void Run()
        {
         
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                char symbol = key.KeyChar;
                if (symbol == 'c')
                    break;
                else
                {
                    OnKeyPressed.Invoke(this, symbol);
                }
            }
        }
    }
}
