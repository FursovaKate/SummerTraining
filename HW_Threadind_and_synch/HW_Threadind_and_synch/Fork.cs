namespace HW_Threadind_and_synch
{
    public class Fork
    {
        public bool InUse { get; set; }
        public Philosopher Philosopher { get; set; }

        public Fork()
        {
            InUse = false;
            Philosopher = null;
        }
    }
}
