using Events;

Counter counter = new Counter();
counter.OnCounterChange += NotifyAboutEvent;
counter.OnCounterChange += CheckOnSimmpleNum;
counter.IncreaseCounter(8);
counter.DecreaseCounter(1);
counter.IncreaseCounter(2);
counter.DecreaseCounter(1);



void NotifyAboutEvent() => Console.WriteLine("Event exists");

void CheckOnSimmpleNum()
{ 
    Console.WriteLine(counter.CurrentCounter);
 for (int i = 1; i <= counter.CurrentCounter; i++)
 {
     if (counter.CurrentCounter % i == 0 && i != 1 && i != counter.CurrentCounter)
     {
         return;
     }

 }
 Console.WriteLine("New counter is  simple");
}