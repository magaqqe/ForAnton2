// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Jerry");
ABC();
Thread.Sleep(500);
ABC();
Thread.Sleep(500);
ABC();
Thread.Sleep(500);

A();

// функция
void ABC()
{
Console.WriteLine("A");
Console.WriteLine("B");
Console.WriteLine("C");
}

void A()
{
B();
C();
}

void B()
{
Console.WriteLine("BBBBB");
}

void C()
{
Console.WriteLine("CCCCC");
}


void NeIspolzuem(){}