# WiiBalanceWalker v0.5 - by Shachar Liberman
## WiiBalanceWalker v0.4 and before - Released by Richard Perry from GreyCube.com - Under the Microsoft Public License.
***
 released for windows 10 x64 systems, x86 should be supported too.

 Uses lshachar's WiimoteLib DLL:                  https://github.com/lshachar/WiimoteLib
 Uses the 32Feet.NET bluetooth DLL:               http://32feet.codeplex.com/
 Uses vJoy device driver (by Shaul Eizikovich):   http://vjoystick.sourceforge.net/
 (Previous to WiiBalanceWalker v0.5
  VJoy by headsoft was used)                      http://headsoft.com.au/index.php?category=vjoy
***

# WiiBalanceWalker v0.5 progress over v0.4:
	o Virtual joystick Support for x64 systems
	o Can send values directly measured from each of the load sensors, to the virtual joystick interface.
	o Instructions for adding / removing bluetooth devices updated for windows 10. 
	o Easier to make permanent connections with the balance board by using permanent PIN code
	o New startup options makes usage even easier
	o New option to tare the balance board (brings all current measurments to zero. use this button while you're off the balance board)
	o Measured values are now in real kilograms (previously they were 4 times too large)
	o Added some helpful tooltips, try to hover your mouse over things to get some explanations.

Get your compiled archive in the [Releases section](https://github.com/lshachar/Wiibalancewalker/releases)
for virtual joystick support, [install vJoy by Shaul Eizikovich](http://vjoystick.sourceforge.net/site/index.php/download-a-install/download)