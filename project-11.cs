int[] inventory = [200,450,700,175,250]; // finished products
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum +=items;
    bin++;
    Console.WriteLine($"Bin number {bin} has {items} items (Running total so far: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");
