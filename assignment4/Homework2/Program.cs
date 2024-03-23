namespace Homework2
{
    public class Clock
    {
        //定义事件委托
        public delegate void TickHandler(object sender, EventArgs e);
        public delegate void AlarmHandler(object sender, EventArgs e);

        public event TickHandler Tick;
        public event AlarmHandler Alarm;

        // 触发Tick事件
        protected virtual void OnTick()
        {
            Tick?.Invoke(this, EventArgs.Empty);
        }

        // 触发Alarm事件
        protected virtual void OnAlarm()
        {
            Alarm?.Invoke(this, EventArgs.Empty);
        }

        public void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                OnTick();
                if (i%3==0)
                {
                    OnAlarm();
                }
            }
        }
    }
    internal class Subcriber
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            //订阅事件
            clock.Tick += (sender, e) => Console.WriteLine("Tick...Tick..");
            clock.Alarm += (sender, e) => Console.WriteLine("Alarm! Ti's time to go to school!");

            clock.Start();
        }
    }
}
