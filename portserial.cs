using System;
using System.IO.Ports;
//using System.Threading;

public class Class1
{
    private string buffer { get; set; }
    private SerialPort _port { get; set; }

    public Port()
    {
        _port = new SerialPort();
        _port.DataReceived += new SerialDataReceivedEventHandler(dataReceived);
        buffer = string.Empty;
    }

    private void dataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        buffer += _port.ReadExisting();

        //test for termination character in buffer
        if (buffer.Contains("\r\n"))
        {
            //run code on data received from serial port
        }
    }
}
