using Internal;
using System;
public class ChiTieu
{
    private int Income;
    private int Outcome;
    private double Balances;
    private double Cost;
    public ChiTieu(int Income,int Outcome)
    {
        this.Income = Income;
        this.Outcome = Outcome;
    }
    public double BALANCES
    {
        get { 
            Balances = Income - Outcome;
            Cost = Outcome/Income*100
            if (Balances < 10 || Cost >90)
            {
                Console.WriteLine("Sap Het Tien !");
                Console.WriteLine(Cost);
            }
            return Balances;
            }
    }
    public double COST
    {
        get { return Outcome/Income*100; }
    }
}
class Program
{

    static void Main()
    {
        ChiTieu chitieu = new ChiTieu(100,90);
        Console.WriteLine($"Cost: {chitieu.COST}%");
        Console.WriteLine($"Balances: {chitieu.BALANCES}");
    }
}