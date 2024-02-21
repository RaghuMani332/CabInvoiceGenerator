class Program
{
    static void Main()
    {
        Console.WriteLine("hii");
        Console.WriteLine(CabInvoice.TotalFare(5,2));
    }
}
public class CabInvoice
{
    static double costPerKM=10;
    static double costPerMin=10;
    static double MinFare=5;
    public static double TotalFare(double distance,int time)
    {
        double totval=(distance*costPerKM)+(time*costPerMin);
        return Math.Max(totval,MinFare);
    }
}
