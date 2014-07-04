// Using delegates write a class Timer that has can execute certain method at each t seconds
namespace TimerWithDelegates
{
    class Test
    {
        static void Main(string[] args)
        {
            // create new timer with the loop method
            Timer timer = new Timer(TimerClass.MethodToRepeat); 

            // and use it
            timer("I'm gonna repeat that every second", 1); 
        }
    }
}
