namespace TopCoder;

class Program
{
    public static void Main(string[] args)
    {
        
    }

    #region KiwiJuiceExample
    public static void KiwiJuiceClientCode()
    {
        var kiwiJuice = new KiwiJuiceEasy();

        var example1 = kiwiJuice.ThePouring(new int[] { 20, 20 }, new int[] { 5, 8 }, new int[] { 0 }, new int[] { 1, });
        Print("Excample1: ", example1);
        var example2 = kiwiJuice.ThePouring(new int[] { 10, 10 }, new int[] { 5, 8 }, new int[] { 0 }, new int[] { 1, });
        Print("Excample2: ", example2);
        var example3 = kiwiJuice.ThePouring(new int[] { 30, 20, 10 }, new int[] { 10, 5, 5 }, new int[] { 0, 1, 2 }, new int[] { 1, 2, 0 });
        Print("Excample3: ", example3);
        var example4 = kiwiJuice.ThePouring(new int[] { 14, 35, 86, 58, 25, 62 }, new int[] { 6, 34, 27, 38, 9, 60 }, new int[] { 1, 2, 4, 5, 3, 3, 1, 0 }, new int[] { 0, 1, 2, 4, 2, 5, 3, 1 });
        Print("Excample4: ", example4);
        var example5 = kiwiJuice.ThePouring(new int[] { 700000, 800000, 900000, 1000000 }, new int[] { 478478, 478478, 478478, 478478 }, new int[] { 2, 3, 2, 0, 1 }, new int[] { 0, 1, 1, 3, 2 });
        Print("Excample5: ", example5);
    }

    public static void Print(string message, int[] datas)
    {
        Console.WriteLine(message);
        foreach (var element in datas)
        {
            Console.Write($"{element}, ");
        }
        Console.WriteLine();
    }
    #endregion
}