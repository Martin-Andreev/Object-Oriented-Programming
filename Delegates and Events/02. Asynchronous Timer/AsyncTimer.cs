namespace AsynchronousTimer
{
    using System;
    using System.Threading;

    class AsyncTimer
    {
        private Action<int> actionMethod;
        private int tickCount;
        private int interval;

        public AsyncTimer(Action<int> actionMethod, int tickCount, int interval)
        {
            this.actionMethod = actionMethod;
            this.tickCount = tickCount;
            this.interval = interval;
        }

        public static void PrintTime(int ticks)
        {
            Console.WriteLine("Ticks left: " + ticks);
        }

        public int TickCount
        {
            get { return this.tickCount; }
            set { this.tickCount = value; }
        }

        public int Interval
        {
            get { return this.interval; }
            set { this.interval = value; }
        }

        public void Run()
        {
            while (this.TickCount > 0)
            {
                this.actionMethod(this.tickCount);
                this.tickCount--;
                Thread.Sleep(this.Interval);
            }
        }
    }
}