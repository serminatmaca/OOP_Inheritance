using OOP_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    { //Human sınıfından human adını verdiğim bir nesne yaratıldı..
        // classın tüm açık olarak yaratılmış propertylerine bilgi girebildim.
        Human human = new Human();

        human.Name = "Sermin";
        human.SurName = "Atmaca";
        human.Gender = "K";
        human.Age = 29;
        human.Adress = "Beylikdüzü";


        Personnel personnel = new Personnel();

        personnel.Name = "Muzaffer";
        personnel.Age = 29;
        personnel.Adress = "Beylikdüzü";

        SalesRep salesRep = new SalesRep();

        salesRep.SalesAmount = 500;
        salesRep.Name = "Abuzittin";
        salesRep.Age = 30;
        salesRep.Title = "Satış Sorumlusu";


        Customer customer = new Customer();

        customer.CompanyName = "Novas Works Ltd.";
        customer.Name = "Muzo";

        Console.WriteLine

        
        Console.ReadKey();
    }
}