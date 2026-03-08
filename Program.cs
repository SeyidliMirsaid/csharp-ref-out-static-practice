using System;

namespace Ref_OutConstructor_Static_05._22._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            Bank KapitalBank = new Bank("Birbank", 96000);

            KapitalBank.HeadBranch = "Nerimanov Filiali";
            //Console.WriteLine("Name: " + KapitalBank.Name + "HeadBranch: " +
            //    KapitalBank.HeadBranch + "InitialCount: " + KapitalBank.InitialCount);

            Bank PashaBank = new Bank("Pasha", 74000);

            PashaBank.HeadBranch = "Port Baku Filiali";
            //Console.WriteLine("Name: " + PashaBank.Name + "HeadBranch: " +
            //    PashaBank.HeadBranch + "InitialCount: " + PashaBank.InitialCount);

            #endregion

            #region

            Citizen first = new Citizen("Elnare");

            Console.WriteLine(Citizen.CitizenCount);
            Console.WriteLine(first.CitizenCountNonStatic);
            Console.WriteLine(first.Name);

            Citizen second = new Citizen("Seyid");

            Console.WriteLine(Citizen.CitizenCount); // 
            Console.WriteLine(second.CitizenCountNonStatic);
            Console.WriteLine(second.Name);

            Citizen third = new Citizen("Sara");

            Console.WriteLine(Citizen.CitizenCount);
            Console.WriteLine(third.CitizenCountNonStatic);
            Console.WriteLine(third.Name);

            Sun.Degree(270);
            #endregion

            int result = 3;
            int noResult;
            // out baslangicda deyer teleb etmir 
            // ref ise baslangicda deyer teleb edir.
            intTryParse(out noResult, "1", ref result);
            //Console.WriteLine(result + " out olmayan deyer");
            //Console.WriteLine(noResult + " out olan deyer");

        }
        static void intTryParse(out int outValue, string value, ref int noResult_)
        {
            outValue = 7;
            noResult_ = 8;
        }
    }
}


class Bank
{
    public Bank() { }
    public Bank(string name, int initialCount)
    {
        this.Name = name;
        this.InitialCount = initialCount;
    }
    public Bank(int initialCount)
    {
        this.InitialCount = initialCount;
    }

    public static int BankCount { get; set; } = 0;
    public string HeadBranch { get; set; }
    public string Name { get; set; }
    public int InitialCount { get; set; }
    public bool hasAny { get; set; }
}
class Citizen
{
    public static int CitizenCount { get; set; } = 0;
    public int CitizenCountNonStatic { get; set; } = 0;
    public string Name { get; set; }
    public string Surname { get; set; }
    public string CitizenShip { get; set; }
    public string Gender { get; set; }
    
    public Citizen() { }
    public Citizen(string name)
    {
        this.Name = name;
        CitizenCount++;
        CitizenCountNonStatic++;
    }

}
static class Sun
{
    public static int Heat { get; set; }
    public static void Degree(decimal num)
    {
        Console.WriteLine("Derece yuksekdir");
    }
    static Sun() { }
}