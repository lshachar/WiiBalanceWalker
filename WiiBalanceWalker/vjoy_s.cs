/////////////////////////////////////////////////////////////////////////////////////////////////////////
//
// This project demonstrates how to write a simple vJoy feeder in C#
//
// You can compile it with either #define ROBUST OR #define EFFICIENT
// The fuctionality is similar - 
// The ROBUST section demonstrate the usage of functions that are easy and safe to use but are less efficient
// The EFFICIENT ection demonstrate the usage of functions that are more efficient
//
// Functionality:
//	The program starts with creating one joystick object. 
//	Then it petches the device id from the command-line and makes sure that it is within range
//	After testing that the driver is enabled it gets information about the driver
//	Gets information about the specified virtual device
//	This feeder uses only a few axes. It checks their existence and 
//	checks the number of buttons and POV Hat switches.
//	Then the feeder acquires the virtual device
//	Here starts and endless loop that feedes data into the virtual device
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////
#define ROBUST
//#define EFFICIENT

using System;
using System.Windows.Forms;

// Don't forget to add this
using vJoyInterfaceWrap;
using WiiBalanceWalker;
using WiimoteLib;

namespace WiiBalanceWalker
{
    class VJoyFeeder
    {
        // Declaring one joystick (Device id 1) and a position structure. 
        static public vJoy joystick;
        static public vJoy.JoystickState iReport;
        static public uint id = 1;


        public static void Initialize(uint id)  //(string[] args)
        {
            // Create one joystick object and a position structure.
            joystick = new vJoy();
            iReport = new vJoy.JoystickState();

            string buffer;
            // Device ID can only be in the range 1-16
            if (id < 1 || id > 16)
            {
                buffer = string.Format("Illegal device ID {0}\nExit!", id);
                BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
                return;
            }

            // Get the driver attributes (Vendor ID, Product ID, Version Number)
            if (!joystick.vJoyEnabled())
            {
                BalanceWalker.FormMain.consoleBoxWriteLine("vJoy driver not enabled: Failed Getting vJoy attributes.\n");
                return;
            }
            else
            {
                buffer = string.Format("Vendor: {0}\nProduct :{1}\nVersion Number:{2}\n", joystick.GetvJoyManufacturerString(), joystick.GetvJoyProductString(), joystick.GetvJoySerialNumberString());     //BalanceWalker.FormMain.consoleBoxWriteLine($"Vendor: {joystick.GetvJoyManufacturerString()}\nProduct :{joystick.GetvJoyProductString()}\nVersion Number:{joystick.GetvJoySerialNumberString()}\n");
                BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            }


            // Get the state of the requested device
            VjdStat status = joystick.GetVJDStatus(id);
            switch (status)
            {
                case VjdStat.VJD_STAT_OWN:
                    buffer = string.Format("vJoy Device {0} is already owned by this feeder\n", id);
                    BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
                    break;
                case VjdStat.VJD_STAT_FREE:
                    buffer = string.Format("vJoy Device {0} is free\n", id);
                    BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
                    break;
                case VjdStat.VJD_STAT_BUSY:
                    buffer = string.Format("vJoy Device {0} is already owned by another feeder\nCannot continue\n", id);
                    BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
                    return;
                case VjdStat.VJD_STAT_MISS:
                    buffer = string.Format("vJoy Device {0} is not installed or disabled. \nCannot continue\n", id);
                    BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
                    return;
                default:
                    buffer = string.Format("vJoy Device {0} general error\nCannot continue\n", id);
                    BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
                    return;
            };

            // Check which axes are supported
            bool AxisX = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_X);
            bool AxisY = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_Y);
            bool AxisZ = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_Z);
            bool AxisRX = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_RX);
            bool AxisRZ = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_RZ);
            bool AxisRY = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_RY);
            // Get the number of buttons and POV Hat switches supported by this vJoy device
            int nButtons = joystick.GetVJDButtonNumber(id);
            int ContPovNumber = joystick.GetVJDContPovNumber(id);
            int DiscPovNumber = joystick.GetVJDDiscPovNumber(id);

            // Print results
            buffer = string.Format("\nvJoy Device {0} capabilities:\n", id);
            BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            buffer = string.Format("Number of buttons\t\t{0}\n", nButtons);
            BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            buffer = string.Format("Number of Continuous POVs\t{0}\n", ContPovNumber);
            BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            buffer = string.Format("Number of Descrete POVs\t\t{0}\n", DiscPovNumber);
            BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            buffer = string.Format("Axis X\t\t{0}\n", AxisX ? "Yes" : "No");
            BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            buffer = string.Format("Axis Y\t\t{0}\n", AxisY ? "Yes" : "No");
            BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            buffer = string.Format("Axis Z\t\t{0}\n", AxisZ ? "Yes" : "No");
            BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            buffer = string.Format("Axis Rx\t\t{0}\n", AxisRX ? "Yes" : "No");
            BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            buffer = string.Format("Axis Ry\t\t{0}\n", AxisRY ? "Yes" : "No");
            BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            buffer = string.Format("Axis Rz\t\t{0}\n", AxisRZ ? "Yes" : "No");
            BalanceWalker.FormMain.consoleBoxWriteLine(buffer);

            if (!(AxisX && AxisY && AxisZ && AxisRX && AxisRZ && AxisRY))
            {
                buffer = string.Format("Please enable Axes X,Y,Z,RX,RY,RZ in vJoyConf for device number", id, " in order to use all functions", id);
                BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            }
            if (nButtons < 1)
            {
                buffer = string.Format("Please enable at least 1 button in vJoyConf for device ", id, " in order to use the only button on the wii balance board");
                BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            }
            // Test if DLL matches the driver
            UInt32 DllVer = 0, DrvVer = 0;
            bool match = joystick.DriverMatch(ref DllVer, ref DrvVer);
            if (match)
            {
                buffer = string.Format("Version of Driver Matches DLL Version ({0:X})\n", DllVer);
                BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            }
            else
            {
                buffer = string.Format("Version of Driver ({0:X}) does NOT match DLL Version ({1:X})\n", DrvVer, DllVer);
                BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            }

            // Acquire the target
            if ((status == VjdStat.VJD_STAT_OWN) || ((status == VjdStat.VJD_STAT_FREE) && (!joystick.AcquireVJD(id))))
            {
                buffer = string.Format("Failed to acquire vJoy device number {0}.\n", id);
                BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
                return;
            }
            else
            {
                buffer = string.Format("Acquired: vJoy device number {0}.\n", id);
                BalanceWalker.FormMain.consoleBoxWriteLine(buffer);
            }
            int X, Y, Z, XR, ZR;
            uint count = 0;
            long maxval = 0;    // maxval is -32767 +32767

            X = 20;
            Y = 30;
            Z = 40;
            XR = 60;
            ZR = 80;

            joystick.GetVJDAxisMax(id, HID_USAGES.HID_USAGE_X, ref maxval);

#if ROBUST
            bool res;
            // Reset this device to default values
            joystick.ResetVJD(id);

            // set this to true to test if the vJoy driver is working. This will feed vjoy with an endless loop of joystick commands.

            while (false)
            {
                // Set position of 4 axes
                res = joystick.SetAxis(X, id, HID_USAGES.HID_USAGE_X);
                res = joystick.SetAxis(Y, id, HID_USAGES.HID_USAGE_Y);
                res = joystick.SetAxis(Z, id, HID_USAGES.HID_USAGE_Z);
                res = joystick.SetAxis(XR, id, HID_USAGES.HID_USAGE_RX);
                res = joystick.SetAxis(ZR, id, HID_USAGES.HID_USAGE_RZ);

                // Press/Release Buttons
                res = joystick.SetBtn(true, id, count / 50);
                res = joystick.SetBtn(false, id, 1 + count / 50);

                // If Continuous POV hat switches installed - make them go round
                // For high values - put the switches in neutral state
                if (ContPovNumber > 0)
                {
                    if ((count * 70) < 30000)
                    {
                        res = joystick.SetContPov(((int)count * 70), id, 1);
                        res = joystick.SetContPov(((int)count * 70) + 2000, id, 2);
                        res = joystick.SetContPov(((int)count * 70) + 4000, id, 3);
                        res = joystick.SetContPov(((int)count * 70) + 6000, id, 4);
                    }
                    else
                    {
                        res = joystick.SetContPov(-1, id, 1);
                        res = joystick.SetContPov(-1, id, 2);
                        res = joystick.SetContPov(-1, id, 3);
                        res = joystick.SetContPov(-1, id, 4);
                    };
                };

                // If Discrete POV hat switches installed - make them go round
                // From time to time - put the switches in neutral state
                if (DiscPovNumber > 0)
                {
                    if (count < 550)
                    {
                        joystick.SetDiscPov((((int)count / 20) + 0) % 4, id, 1);
                        joystick.SetDiscPov((((int)count / 20) + 1) % 4, id, 2);
                        joystick.SetDiscPov((((int)count / 20) + 2) % 4, id, 3);
                        joystick.SetDiscPov((((int)count / 20) + 3) % 4, id, 4);
                    }
                    else
                    {
                        joystick.SetDiscPov(-1, id, 1);
                        joystick.SetDiscPov(-1, id, 2);
                        joystick.SetDiscPov(-1, id, 3);
                        joystick.SetDiscPov(-1, id, 4);
                    };
                };

                System.Threading.Thread.Sleep(20);
                X += 150; if (X > maxval) X = 0;
                Y += 250; if (Y > maxval) Y = 0;
                Z += 350; if (Z > maxval) Z = 0;
                XR += 220; if (XR > maxval) XR = 0;
                ZR += 200; if (ZR > maxval) ZR = 0;
                count++;

                if (count > 640)
                    count = 0;

            } // While (Robust)

#endif // ROBUST
#if EFFICIENT   // todo: unused, from the original vjoy feeder demo code.

            byte[] pov = new byte[4];

      while (true)
            {
            iReport.bDevice = (byte)id;
            iReport.AxisX = X;
            iReport.AxisY = Y;
            iReport.AxisZ = Z;
            iReport.AxisZRot = ZR;
            iReport.AxisXRot = XR;

            // Set buttons one by one
            iReport.Buttons = (uint)(0x1 <<  (int)(count / 20));

		if (ContPovNumber>0)
		{
			// Make Continuous POV Hat spin
			iReport.bHats		= (count*70);
			iReport.bHatsEx1	= (count*70)+3000;
			iReport.bHatsEx2	= (count*70)+5000;
			iReport.bHatsEx3	= 15000 - (count*70);
			if ((count*70) > 36000)
			{
				iReport.bHats =    0xFFFFFFFF; // Neutral state
                iReport.bHatsEx1 = 0xFFFFFFFF; // Neutral state
                iReport.bHatsEx2 = 0xFFFFFFFF; // Neutral state
                iReport.bHatsEx3 = 0xFFFFFFFF; // Neutral state
			};
		}
		else
		{
			// Make 5-position POV Hat spin
			
			pov[0] = (byte)(((count / 20) + 0)%4);
            pov[1] = (byte)(((count / 20) + 1) % 4);
            pov[2] = (byte)(((count / 20) + 2) % 4);
            pov[3] = (byte)(((count / 20) + 3) % 4);

			iReport.bHats		= (uint)(pov[3]<<12) | (uint)(pov[2]<<8) | (uint)(pov[1]<<4) | (uint)pov[0];
			if ((count) > 550)
				iReport.bHats = 0xFFFFFFFF; // Neutral state
		};

        /*** Feed the driver with the position packet - is fails then wait for input then try to re-acquire device ***/
        if (!joystick.UpdateVJD(id, ref iReport))
        {
            Console.WriteLine("Feeding vJoy device number {0} failed - try to enable device then press enter\n", id);
            Console.ReadKey(true);
            joystick.AcquireVJD(id);
        }

        System.Threading.Thread.Sleep(20);
        count++;
        if (count > 640) count = 0;

        X += 150; if (X > maxval) X = 0;
        Y += 250; if (Y > maxval) Y = 0;
        Z += 350; if (Z > maxval) Z = 0;
        XR += 220; if (XR > maxval) XR = 0;
        ZR += 200; if (ZR > maxval) ZR = 0;  
         
      }; // While

#endif // EFFICIENT

        }

        static public void Setjoystick(int X, int Y, int Z, int XR, int YR, int ZR, bool aButton)
        {
            joystick.SetAxis(X, id, HID_USAGES.HID_USAGE_X);
            joystick.SetAxis(Y, id, HID_USAGES.HID_USAGE_Y);
            joystick.SetAxis(Z, id, HID_USAGES.HID_USAGE_Z);
            joystick.SetAxis(XR, id, HID_USAGES.HID_USAGE_RX);
            joystick.SetAxis(YR, id, HID_USAGES.HID_USAGE_RY);
            joystick.SetAxis(ZR, id, HID_USAGES.HID_USAGE_RZ);
            joystick.SetBtn(aButton, id, 1);

            //string values = string.Format("X:{0,6:#####}  Y:{1,6:#####}  Z:{2,6:#####}  XR:{3,6:#####}  YR:{4,6:#####}  ZR:{5,6:#####}", X,Y,Z,XR,YR,ZR);
            //Console.WriteLine(values);
        }
    }
}
