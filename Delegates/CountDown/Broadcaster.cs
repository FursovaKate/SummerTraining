using System.Threading;

namespace CountDown
{
    public class Broadcaster
    {
        public delegate void EventHandler();

        public event EventHandler OnCountDown;

        public void CountDown(int userInput)
        {
            Thread.Sleep(userInput);
            OnCountDown?.Invoke();
        }
    }
}