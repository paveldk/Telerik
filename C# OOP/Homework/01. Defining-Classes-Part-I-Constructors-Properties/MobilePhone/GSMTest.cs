namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public const decimal PricePerSecond = 0.37M; 

        static void Main()
        {
            Random rand = new Random();

            /* First I'm gonna test classes for GSMs. I'm gonna create 5 Phones 
             * with Constructors using every field. For this I'm gonna need Display and Battery
             * information, and becouse of that I'm gonna create each time someBattery and
             * someDisplay. for the Battery I'm gonna need type from the enumeration and on
             * random choice I'm gonna pick one of the 3 choices.
             * */
            GSM[] phones = new GSM[5];

            for (int i = 0; i < phones.Length; i++)
            {
                int curentNumber = i + 1;
                BatteryType batteryType;
                int choice = rand.Next(1, 4);
                switch (choice)
                {
                    case 1: 
                        batteryType = BatteryType.LiIon;
                        break;
                    case 2:
                        batteryType = BatteryType.NiCd;
                        break;
                    case 3:
                        batteryType = BatteryType.NiMH;
                        break;
                    default:
                        batteryType = BatteryType.LiIon;
                        break;
                }

                Battery someBattery = new Battery("Model for SamsungS" + curentNumber, rand.Next(1, 200), rand.Next(1, 50), batteryType);
                Display someDisplay = new Display(i + 3.5, 16000000);
                phones[i] = new GSM("SamsungS" + curentNumber, "Samsung", rand.Next(1, 1500), "me", someBattery, someDisplay);    
            }

            // After I created the phones it's time to print them
            foreach (var phone in phones)
            {
                Console.WriteLine(phone);    
            }

            // And the "special" one :)
            Console.WriteLine(GSM.IPhone4S);
            
            // now I'm gonna test the Calls. First I'm gonna add some calls to phone[0]
            Console.WriteLine("-------------Adding calls-------------------");
            for (int i = 0; i < 10; i++)
            {
                // I'm gonna use same date, only hours gonna be different from 13 to 22
                DateTime date = new DateTime(2014, 1, 31, 13 + i, 33, 00);

                // duration gonna be rand from 1 to 99 sec
                Call newCall = new Call(date, "0888657673", (uint)rand.Next(1, 100));

                // and we add it
                phones[0].AddCall(newCall);    
            }
            
            // Let's see what we add so far:            
            foreach (var call in phones[0].CallHistory)
            {
                Console.WriteLine(call);    
            }

            // and calculate total cost:
            Console.WriteLine("Total cost: {0}", phones[0].CalculateCost(PricePerSecond));

            // now we must find the longest duration, with a loop
            uint longestDuration = 0;
            Call longestCall = phones[0].CallHistory[0];

            for (int i = 0; i < phones[0].CallHistory.Count; i++)
            {
                if (longestDuration < phones[0].CallHistory[i].Duration)
                {
                    // each time when we find longer we change the longestDuration and keep longestCall
                    longestDuration = phones[0].CallHistory[i].Duration;
                    longestCall = phones[0].CallHistory[i];
                }    
            }

            Console.WriteLine();
            Console.WriteLine("--------------Longest call------------------");           
            Console.WriteLine(longestCall);
            
            // when we find longestCall we use it on Method DeleteCalls and that's how we get rid of it       
            phones[0].DeleteCall(longestCall);

            // Again show the logs
            Console.WriteLine("---------------Calls without longest call-----------------");
            foreach (var call in phones[0].CallHistory)
            {
                Console.WriteLine(call);
            }

            // And calculate, this time wuthout the longest
            Console.WriteLine("Total cost without the longest call: {0}", phones[0].CalculateCost(PricePerSecond));
            
            // we clear the History
            phones[0].ClearHistory();
                        
            // and show empty history, well...we don't show anything at all :)
            Console.WriteLine();
            Console.WriteLine("--------------Calls after clear the history(no calls)------------------");
            foreach (var call in phones[0].CallHistory)
            {
                Console.WriteLine(call);
            }

            // The price for empty history will always be 0, unless you're in Bulgaria :) 
            Console.WriteLine();
            Console.WriteLine("Total cost without any calls :) (I assume it's 0): {0}", phones[0].CalculateCost(PricePerSecond));
        }          
    }
}
