using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crestron.SimplSharp;                          	// For Basic SIMPL# Classes
using Crestron.SimplSharpPro.CrestronThread;        	// For Threading


namespace Example_Crestron_Threading
{
    public class ThreadClass
    {
        Thread runningThread;
        public bool Done;

        public void Start()
        {
            Done = false;
            runningThread = new Thread(ThreadCode, null);
            runningThread.Start();
        }


        private object ThreadCode(object o)
        {
            CrestronConsole.Print("Thread started. Going to print periods until thread is stopped.");

            while (!Done)
            {
                CrestronConsole.Print(".");
                Thread.Sleep(1000);
            }

            return null;
        }

    }

}