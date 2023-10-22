using Events;

Counter counter = new Counter();
counter.OnCounterChange += NotifyAboutEvent;
counter.OnCounterChange += CheckOnSimpleNum;
counter.OverFlow += () =>
{
    Console.WriteLine("Counter was reseted");
    return default;
};
//counter.IncreaseCounter(110);
counter.IncreaseCounter(8);
counter.DecreaseCounter(1);
counter.IncreaseCounter(2);
counter.DecreaseCounter(1);
var answer = () =>
{
    Console.WriteLine("To unsubscribe enter yes");
    return Console.ReadLine();
};
var action = (string s) =>
{
    if (s.ToLower() == "yes")
    {
        counter.OnCounterChange -= NotifyAboutEvent;
        counter.OnCounterChange -= CheckOnSimpleNum;
        Console.WriteLine("Unsubscribed");
    }
        
};

string a = answer()!;
action(a);



void NotifyAboutEvent() => Console.WriteLine("Event exists");

void CheckOnSimpleNum()
{ 
    Console.WriteLine(counter.CurrentCounter);
    if(counter.CurrentCounter == 0)
        return;
    for (int i = 1; i <= counter.CurrentCounter; i++)
    {
     if (counter.CurrentCounter % i == 0 
         && i != 1 
         && i != counter.CurrentCounter)
     {
         return;
     }

    }
    Console.WriteLine("New counter is  simple");
}


