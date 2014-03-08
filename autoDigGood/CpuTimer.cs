using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace autoDigGood
{
    class CpuTimer
    {
        private System.Timers.Timer _checkCPU;
        private int _cpuUsage;


        public CpuTimer()
        {
            //Initialize timers
            _checkCPU = new System.Timers.Timer(1000);
            _checkCPU.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            _checkCPU.Interval = 1000;
            _checkCPU.Enabled = true;
        }


        /// <summary>
        /// This event handler is called whenever the 1 second CPU timer elapses. It calls the 
        /// SetText method in a thread safe manner in order to update the CPU usage text box.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            int cpu = (int)cpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            cpu = (int)cpuCounter.NextValue();
            _cpuUsage = cpu;

            ObjectDelegate cpuTextDel = new ObjectDelegate(SetCPUText);    //enable the manual start button
            cpuTextDel.Invoke(_cpu);

        }//end OnTimedEvent





    }//end CpuTimer
}//end autoDigGood
