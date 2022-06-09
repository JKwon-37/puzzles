int[] RandomArray()
{
    int[] arr = new int[10];
    Random rand = new Random();
    int min = 100;
    int max = arr[0];
    int sum = 0;
    foreach (var thing in arr)
    {
        sum += arr[thing];
        arr[thing] = rand.Next(5,26);
        Console.WriteLine(arr[thing]);
        if (arr[thing] < min)
        {
            min = arr[thing];
        }
        if (arr[thing] > max)
        {
            max = arr[thing];
        }
    }
    Console.WriteLine($"Min is {min}.");
    Console.WriteLine($"Max is {max}.");
    Console.WriteLine($"Sum is {sum}.");
    return arr;
}

string TossCoin()
{
    Random rand = new Random();
    int headsOrTails = rand.Next(0,2);
    string flip = "";
    if (headsOrTails == 0)
    {
        flip = "Heads";
    } else if (headsOrTails == 1)
    {
        flip = "Tails";
    }
    return flip;
}

// RandomArray();
Console.WriteLine(TossCoin());