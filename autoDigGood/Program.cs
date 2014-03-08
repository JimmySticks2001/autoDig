using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoDigGood
{
    // defines the type of method that observes model updates:
    public delegate void Observer();

    //private delegate void CpuTimerDelegate(object obj);

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            DigController _digger = new DigController();

            UserInterface _mainForm = new UserInterface();



            //Application.Run(new UserInterface());
        }//end Main

    }//end Program
}//end autoDigGood
