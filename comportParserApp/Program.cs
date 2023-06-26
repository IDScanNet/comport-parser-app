using System;
using System.IO;
using System.IO.Ports;
using Nautilus;

namespace comportParserApp
{
    public class Program
    {
        public static void Main()
        {
            Reader reader = new Reader();
            reader.SetParameters();
            reader.GetData();
                        
        }//end main Method
    }
}
