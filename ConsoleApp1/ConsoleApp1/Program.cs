class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, world!");
        int[] tab1 = { 1, 2, 3, 4,10 };
        Console.WriteLine(AvgFromArr(tab1));
    }

    static double AvgFromArr(int[] tab)
    {
        int suma = 0;
        int counter = 0;
        foreach(int num in tab)
        {
            suma = suma + num;
            counter++;
        }

        double avg = (double) suma / counter;

        return avg;
    }
}