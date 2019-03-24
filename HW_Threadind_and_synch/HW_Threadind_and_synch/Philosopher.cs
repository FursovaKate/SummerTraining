using System;
using System.Threading;
using System.Threading.Tasks;

namespace HW_Threadind_and_synch
{
    public class Philosopher
    {
        public Philosopher(string name, Fork leftFork, Fork rightFork)
        {
            Name = name;
            LeftFork = leftFork;
            RightFork = rightFork;
        }

        public string Name { get; }
        public Fork LeftFork { get; }
        public Fork RightFork { get; }
        private Semaphore allowedAmount = Waiter.GetAllowed();

        public void EatingHabit(CancellationToken stopDining)
        {
            const int thinkingTime = 20;

            for (var i = 0; ; ++i)
            {
                if (stopDining.IsCancellationRequested)
                {
                    Console.WriteLine($"{Name} is hungry");
                    stopDining.ThrowIfCancellationRequested();
                }

                allowedAmount.WaitOne();
                bool allowedToEat;
                lock (allowedAmount)
                {
                    allowedToEat = IsForksAvailable();
                }
                if (allowedToEat)
                {
                    PhilosopherEat();
                }

                allowedAmount.Release();

                Task.Delay(thinkingTime).Wait(stopDining);
            }
        }

        private bool IsForksAvailable()
        {
            lock (allowedAmount)
            {
                if (LeftFork.InUse)
                {
                    Console.WriteLine($"Left fork is in use");
                    return false;
                }

                if (RightFork.InUse)
                {
                    Console.WriteLine($"Right fork is in use");
                    return false;
                }
            }
            return true;
        }

        private void PhilosopherEat()
        {
            const int eatingDuration = 1000;
            Console.WriteLine($"{Name} is eating.");
            Thread.Sleep(eatingDuration);
            Console.WriteLine($"{Name} is thinking.");
        }
    }
}
