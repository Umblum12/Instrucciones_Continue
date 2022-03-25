//Continue
for (int id = 0; id <= 10; id++)
{
    Thread.Sleep(800);
    if (id == 8)
    {
        Console.WriteLine();
        continue;
    }
    Console.WriteLine(id);
}
Console.ReadKey(true);