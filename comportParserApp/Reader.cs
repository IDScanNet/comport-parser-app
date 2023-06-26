using System;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace comportParserApp
{
    public class Reader
    {
        private readonly StringBuilder indata;
        private readonly SerialPort serial;
        private bool check;
        private readonly Parser p = new Parser();
        public Reader() { 
            indata = new StringBuilder();
            serial = new SerialPort();
        }//end constructor

        public void SetParameters()
        {
            serial.PortName = SetPortName(serial.PortName);
            serial.BaudRate = 9600;
            serial.Parity = Parity.None;
            serial.DataBits = 8;
            serial.StopBits = StopBits.One;
            serial.Handshake = Handshake.None;
            // Set the read/write timeouts
            serial.ReadTimeout = 500;
            serial.WriteTimeout = 500;
            serial.Open();

        }//end method Set Parameters

        private String SetPortName(string portName)
        {
            string pn;
            check = true;
           
            Console.WriteLine("Available Ports:");

            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("{0}", s);
            }

            do
            {
                Console.Write("Enter COM port value (Default: {0}): ", portName);
                pn = Console.ReadLine();
                pn = pn.ToUpper();
                if (pn.StartsWith("COM") && SerialPort.GetPortNames().Contains(pn))
                {
                    check = false;
                }
            } while (check);
            return pn;

        }//end method SetPortName

        public String GetIndata()
        {
            return indata.ToString();
        }
        public void GetData()
        {

          
            serial.DataReceived += new SerialDataReceivedEventHandler(Serial_DataReceived);

      
            Console.WriteLine("Scan your license then press any key to parse");

            Console.ReadKey();
            Console.Write("\n\nData Received: " + indata.ToString());
            p.Parse(GetIndata());
            ClearTS();

            Console.WriteLine("Type 1 to scan again, type anything else to exit.");
            string result = Console.ReadLine();

            if (result.Equals("1"))
            {
                GetData();
            }
            else
            {
                serial.Close();

            }

        }//end method OpenSerialPort

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var message = serial.ReadExisting();
            foreach(char c in message)
            {
                indata.Append(c);

            }
            
        }//end method Serial_DataReceived

        private void ClearTS()
        {
            indata.Clear();
        }
    }
}//end class Program
