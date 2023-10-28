// See https://aka.ms/new-console-template for more information

using SecondKT;

ObservableIntStack stack = new ObservableIntStack(new []{1,2});

stack.Subscribe(FirstSub);
stack.Subscribe(SecondSub);


stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.Pop();
stack.Pop();
stack.Unsubscribe(FirstSub);
stack.Unsubscribe(SecondSub);


void FirstSub(int num)
{
    Console.WriteLine("i`m the first sub " + num);
}

void SecondSub(int num)
{
    Console.WriteLine("i`m the second sub " + num);
}