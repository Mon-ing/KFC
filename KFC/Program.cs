public class Program
{
    public static void Main(string[] args)
    {
         Shop myMoney = new Shop();
        Console.WriteLine("Please input NameMarket :");
        myMoney.NameMarket = Console.ReadLine();
        Console.WriteLine("Please input Address : ");
        myMoney.Number = Console.ReadLine();
        Console.WriteLine("Please input request to register a shop : ");
        myMoney.Name = Console.ReadLine();
        Console.WriteLine("Please input OwnerName : ");
        myMoney.OwnerName = Console.ReadLine();
        Console.WriteLine("Please input Name : ");
        myMoney.OwnerName = Console.ReadLine();
        Console.WriteLine("Please input surname : ");
        myMoney.OwnerName = Console.ReadLine();
        Console.WriteLine("Please input Identification Number : ");
        myMoney.OwnerName = Console.ReadLine(Number);
        PrintInformationInput(myMoney);
        Console.WriteLine("Please input money : ");

        Money MMoney = new Money();
        MMoney.baChange();

    }

    public class Shop
    {
        public string NameMarket;
        public string Address;
        public string OwnerName;
        public string Name;
        public string surname;
        public string Identification;
    }

    static void PrintInformationInput(Shop Information)
    {
        Console.WriteLine("-------- Shop Information --------");
        Console.WriteLine("Shop NameMarket : {0}",Information.NameMarket);
        Console.WriteLine("Address : {0}", Information.Address);
        Console.WriteLine("OwnerName : {0}",Information.OwnerName);
        Console.WriteLine("Name : {0}",Information.Name);
        Console.WriteLine("surname : {0}",Information.surname);
        Console.WriteLine("----------------------------------");
    } 
}
