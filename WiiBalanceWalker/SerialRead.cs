using System;
using System.IO.Ports;
using System.Threading;

namespace SerialReadTest
{
    static class SerialRead
    {
        SerialPort port;

        public static void SerialReadInit()     //static void Main(string[] args)
        {
            Console.WriteLine("Serial read init");
            port = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);
            port.Open();

            while (true)
            {
                Console.WriteLine(port.ReadLine());
            }

        }
        public static void blabla()
        {
            Console.WriteLine(port.ReadLine());
        }
    }
}