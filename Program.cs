class Result
{
    public static void miniMaxSum(List<long> arr)
    {
        long totalSum = arr.Sum();
        long maxSum = totalSum - arr.Min();
        long minSum = totalSum -arr.Max();
Console.WriteLine($"La suma mínima es: {minSum} y la suma máxima es: {maxSum}");    }
}

class Solution
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Por favor, ingrese 5 números enteros separados por espacio:"); 
       List<long> arr = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
       Result.miniMaxSum(arr); 
    }
}
