StreamReader addresses = File.OpenText("C:\\Users\\matti\\source\\repos\\csharp-lista-indirizzi\\addresses.csv");

string intestazione=addresses.ReadLine();
List<Address> list = new List<Address>();
List<Address> listaCorrotta = new List<Address>();
while (!addresses.EndOfStream)
{
    try
    {
        
        string linea = addresses.ReadLine();
        string[] data = linea.Split(",");
        string name = data[0];
        string surname = data[1];
        string street = data[2];
        string city = data[3];
        string province = data[4];
        string zip = data[5];
        Address address = new Address(name,surname,street,city,province,zip);
        list.Add(address);
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("File corrotto");
    }

    
}

addresses.Close();

stampa(list);




void stampa(List<Address> list)
{
    Console.WriteLine("-----\tName \tSurname \tStreet \tCity \tProvince \tZIP-----");
    foreach (Address address in list)
    {
        Console.WriteLine($"\t{address.Name} \t{address.Surname} \t{address.Street} \tCity \t{address.Province} \t{address.Zip}");
    }
}
public class Address
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Zip { get; set; }

    

    public Address(string name, string surname, string street, string city, string province, string zip)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
    }


   
}