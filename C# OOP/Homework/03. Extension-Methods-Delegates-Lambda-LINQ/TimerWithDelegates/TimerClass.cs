namespace TimerWithDelegates
{
    using System;
    using System.Diagnostics;

    // First to declare the delegate
    public delegate void Timer(string message, int seconds); 
   
    public class TimerClass
    {
        // Creating void method with same atributes like delegate
        public static void MethodToRepeat(string message, int seconds) 
        {
            // we gonna use Stopwatch
            Stopwatch sw = new Stopwatch();
 
            // start timing
            sw.Start(); 
            while (true)
            {
                if (sw.ElapsedMilliseconds == seconds * 1000) 
                {
                    Console.WriteLine(message);
                    
                    // and restart it
                    sw.Restart(); 
                }
            }
        }
    }
}
