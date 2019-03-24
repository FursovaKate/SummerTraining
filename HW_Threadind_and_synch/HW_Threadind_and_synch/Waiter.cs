using System.Threading;

namespace HW_Threadind_and_synch
{
    public static class Waiter
    {
        public static Semaphore GetAllowed()
        {
            var allowedAmount = new Semaphore(2, 2);
            return allowedAmount;
        }
    }
}
