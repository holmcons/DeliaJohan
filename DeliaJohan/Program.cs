// Exemple code from LINQ exercices:


List<Customer> customers = new List<Customer>()
        //{
        //            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
        //            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
        //            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
        //            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
        //            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
        //            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
        //            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
        //            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
        //            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
        //            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        // };

var s = customers.Select(x => new
{
    LastName = x.Name.Split(' ')[^1],
    //LeftToSave = x.Balance < 1000000 ? 1000000 -.x.Balace :0
    LeftToSave = 1000000 - x.Balance

}).ToList();

foreach (var a in s)
{
    if (a.LeftToSave > 0)
    {
        Console.WriteLine($"{a.LastName}  has to save {a.LeftToSave} kr to become a milionaire");
    }
    else
    {
        Console.WriteLine($"{a.LastName} already is big G");
    }
}
    

    public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}
