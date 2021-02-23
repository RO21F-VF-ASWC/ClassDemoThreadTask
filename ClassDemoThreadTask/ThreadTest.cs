using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassDemoThreadTask
{
    public class ThreadTest
    {
        private static bool done;    // Static fields are shared between all threads

        public static void StartThreadTest()
        {
            new Thread(Go).Start();
            Go();
        }

        private static void Go()
        {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }

    }
}
