using System;
using System.IO.Ports;
using System.Threading;

namespace SerialReadTest
{
    class SerialRead
    {
        public static void SerialReadInit()     //static void Main(string[] args)
        {
            Console.WriteLine("Serial read init");
            SerialPort port = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);
            port.Open();
            while (true)
            {
                Console.WriteLine(port.ReadLine());
            }

        }
    }
}