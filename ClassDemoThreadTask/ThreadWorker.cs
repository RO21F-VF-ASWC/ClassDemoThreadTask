using System;
using System.Threading.Tasks;

namespace ClassDemoThreadTask
{
    public class ThreadWorker
    {
        public ThreadWorker()
        {
        }

        public void Start()
        {
            //ThreadTest.StartThreadTest();

            //Task.Run(() => DoWork("Number One"));
            //Task.Run(() => DoWork("Number Two"));

            CriticalRegionTest critRegion = new CriticalRegionTest();
            critRegion.Start();


        }



        private void DoWork(String name)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Name {name} no={i}");
            }
        }
    }
}