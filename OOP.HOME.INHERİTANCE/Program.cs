using OOP.HOME.INHERİTANCE;

internal class Program
{
    private static void Main(string[] args)
    {
       Host host = new Host();

        host.Name = "Sermin";
        host.LastName = "Atmaca";
        host.City = "Istanbul"; 
        
       HomeInformation homeInformation= new HomeInformation();

        homeInformation.district = "Beylikdüzü";
        homeInformation.SquareMeters = 120;
        homeInformation.NumberOfRooms = 4;
        homeInformation.NumberOfBathrooms = 2;
        homeInformation.AgeOfTheHouse = 12;
        homeInformation.SalePrice = 100000;

        Tenant tenant = new Tenant();

        tenant.Name = "Muzaffer";
        tenant.LastName = "Atmaca";
        tenant.CityOfResidance = "Istaanbul";
        tenant.Bitch = 90000;


        Console.WriteLine("Host Adı:" + host.Name + '\n' + "Satılan evin metrekaresi" + " " + homeInformation.SquareMeters + " " + "dir" );
        Console.ReadKey();
    }
}