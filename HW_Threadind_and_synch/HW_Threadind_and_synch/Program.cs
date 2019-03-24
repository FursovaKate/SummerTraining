using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HW_Threadind_and_synch
{
    class Program
    {
        static void Main()
        {
            var forks = new List<Fork>();
            for (var i = 0; i < 5; i++)
            {
                forks.Add(new Fork());
            }
            var philosophers = new List<Philosopher>();
            for (var i = 0; i < 5; i++)
            {
                philosophers.Add(new Philosopher(i + " philosopher", forks.ElementAt(i), forks.ElementAt(i)));
            }
            var eatingQueue = new List<Task>();

            var eatingCancel = new CancellationTokenSource();
            var askStopEating = eatingCancel.Token;
            foreach (var philosopher in philosophers)
            {
                eatingQueue.Add(Task.Factory.StartNew(() => philosopher.EatingHabit(askStopEating), askStopEating));
            }
            Task.Delay(20000).Wait(askStopEating);
            Task.WaitAll(eatingQueue.ToArray());
            eatingCancel.Dispose();
        }
    }
}
