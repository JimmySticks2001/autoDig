autoDig v0.5
============
This content is released under the [MIT License](http://opensource.org/licenses/MIT) and 
contains content created by [Ramunas Geciauskas](http://keyboardmousehooks.codeplex.com/).


Version history
---------------

#####v0.5 3/6/2014
* Redoing the program to use MVC architecture.
* Added a repository on GitHub: github.com/JimmySticks2001/autoDig
* Added MIT license.

#####v0.4 1/20/2014
* Added a button to clear the log.
* Added a version checker in the menu.
* Added a field where user can change the name of the starting batch file.
* Added a menu option to set the defaults for the program. 
* Added tooltips on user changable fields.

#####v0.3 1/15/2014
* Added mouse tracking.
* Added GUI:
	CPU threshold Inactive time, and Active time can be changed on the fly.
	Mouse tracking and auto start/stop can be toggled.
	A status window logs the current state of the program.
* Added ability to stop and start miners manually.
* Added config file. (see comments below)
* Removed command line arguments.

#####v0.2 1/13/2014
* Fixed a memory leak.
* Fixed multiple instances of miners being run.
* Fixed miner startup causing CPU% threshold to be crossed.
* Added command line arguments.
* Added display of command line settings. 

#####v0.1 1/12/2014
original


Requirements
------------
.NET Framework 4.0


What is it?
-----------
This program will actively monitor the CPU usage of a computer. When the CPU 
has minimal activity for a set number of minutes (inactiveWaitMinutes) the 
program will run a batch file. This should be the batch file you use to start 
your miner. The program will need the batch file to be named "myConfig.bat" 
and it will need to be in the same folder as the executable. 

After the batch file has been run the miner will start. If the CPU sees 
activity above the cpuThreshold%, a user must be doing stuff on the 
workstation. The program will then end the miners operation and wait for the 
CPU usage to drop below cpuThreshold% for the set number of minutes. If the 
mouse capture box is checked, the miner will stop as soon as the mouse is 
moved, this will also reset the inactivity timer. 

CPU monitoring is used as an indication that the computer is doing something 
important and should not have a miner running. Mouse monitoring is used as an
indication that a user is currently using the computer and shouldn't have 
the miner using up all of the GPU.

This will work with cudaminer and cgminer as of now. Other miners can be added
if need be.


How do I use it?
----------------
To "install" autoDig just place it, its config file, and kill.bat into your 
miners folder. It will need to be in the same folder as your miners start-up 
batch file. 
After moving those three files, re-name your miners start-up batch file to 
"myConfig.bat". This is how autoDig knows witch batch file to run when it 
needs to start the miner. 

Once the above two steps are done you may now start autoDig. 

The first user changeable field will be the CPU threshold%. This is the cutoff 
for max CPU usage allowable by the program while a miner is running. Once CPU 
usage crosses above this point the Active timer will be started.

The second field is the Inactive time in minutes. This is how long the program 
waits to start the miner when the CPU usage is below the threshold. This can 
have a decimal value, ex. 0.1, 10.3 and so on.

The third field is the Active time in seconds. This is how long the program 
waits after it sees CPU usage above the threshold before shutting off the 
miner. The CPU will need to stay above the threshold for the length of the 
Active time in order for the miner to be stopped.

The fourth field is the batch file name. This is how you can define which 
batch file the program will run to start you miner. Don't leave it blank. By 
default it will be "myConfig".

The fifth changeable field is the Auto Start/Stop checkbox. This toggles the 
automation of the program. With the box checked the program will actively 
monitor CPU usage and start and stop the miner when appropriate. With the box 
unchecked the program does nothing but you can still manually start and stop 
the miner yourself by using the Manual Start and Manual Stop buttons.

The last field is the Capture mouse checkbox. This field is only enabled if 
the Auto Start/Stop checkbox is checked. When the Capture mouse box is checked 
the program will actively monitor mouse movement. If a miner is running the 
program will stop the miner as soon as the mouse is moved. If a miner is not 
running the program will reset the inactivity timer. 

If you don't want to set these values each time you start the program, you can 
set them as defaults in the config.config file. Each field is represented 
below:

autoStartStop:(true/false) - Turns on automatic operation at startup. 
captureMouse:(true/false) - Turns on or off the global mouse hook at startup. 
If autoStartStop is set to false, a true setting here has no effect.
cpuThreshold%:(0-100) - Sets the threshold which defines computer usage.
inactiveWaitMinutes:(0.1-60) - Sets the time the program will wait until 
starting a miner.
activeWaitSeconds:(1-30) - Sets the time the program will wait until stopping 
the miner. 

If you have adjusted the fields to your liking while the program is running, 
go to the menu under Utilitied and select "Set defaults". This will write all 
of the fields to the config file and your program will start up with these 
settings.
