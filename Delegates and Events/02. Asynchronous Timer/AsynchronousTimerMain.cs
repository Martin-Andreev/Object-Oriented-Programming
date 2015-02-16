namespace AsynchronousTimer
{
    using System;
    using System.Threading;

    public class AsynchronousTimerMain
    {
        public static void Main()
        {
            AsyncTimer asyncTimer = new AsyncTimer(AsyncTimer.PrintTime, 10, 1000);
            Thread timerThread = new Thread(asyncTimer.Run);
            timerThread.Start();
            Console.WriteLine("This will be executed first!");
            Thread.Sleep(3000);
            Console.WriteLine("Test print");
            Thread.Sleep(5000);
            Console.WriteLine("Just one more");
        }
    }
}
