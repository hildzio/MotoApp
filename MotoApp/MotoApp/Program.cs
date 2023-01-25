using MotoApp;

var stack = new BasicStack();
stack.Push(item: 4.5);
stack.Push(item: 43);
stack.Push(item: 333.6);

double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}
Console.WriteLine($"Sum: {sum}");