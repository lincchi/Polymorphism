using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    public class PrinterWindows
    {
        public string Name { get; set; }
        public virtual void Show()
        {
            Console.WriteLine("Printer display dimension : ....");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printer is printing ....");
        }
    }
}
