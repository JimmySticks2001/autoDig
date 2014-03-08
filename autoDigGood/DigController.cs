using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using RamGecTools;

namespace autoDigGood
{
    class DigController
    {
        private List<Observer> _observers = new List<Observer>();    //registry of event handlers


        public DigController()
        {
            

        }//end DigController


        /// <summary>
        /// Adds an event handler method to the registry
        /// </summary>
        /// <param name="form"></param>
        public void register(Observer form)
        {
            _observers.Add(form);
        }



    }//end DigController
}//end autoDigGood
