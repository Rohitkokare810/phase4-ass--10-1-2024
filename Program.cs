// See https://aka.ms/new-console-template for more information

List<Products> products = new List<Products>()
{
    new Products() { PName="Mobile",PPrice=22000,Brand="Samsung",MDate=new DateTime(day:12,month:11,year:2022),EDate=new DateTime(day:14,month:12,year:2024)},
   new Products() { PName="TV",PPrice=22000,Brand="Samsung",MDate=new DateTime(day:12,month:11,year:2022),EDate=new DateTime(day:14,month:12,year:2024)},
   new Products() { PName="Smart Watch",PPrice=22000,Brand="Samsung",MDate=new DateTime(day:12,month:11,year:2022),EDate=new DateTime(day:14,month:12,year:2024)},
   new Products() { PName="Mobile",PPrice=22000,Brand="Samsung",MDate=new DateTime(day:12,month:11,year:2022),EDate=new DateTime(day:14,month:12,year:2024)},
   new Products() { PName="Headphone",PPrice=22000,Brand="Samsung",MDate=new DateTime(day:12,month:11,year:2022),EDate=new DateTime(day:14,month:12,year:2024)},
};
Console.WriteLine("PName \t PPrice \t Brand \t MDate \t\t EDate");
foreach (Products pro in products)
{
    Console.Write(pro.PName + "\t \t");
    Console.Write(pro.PPrice + "\t \t");
    Console.Write(pro.Brand + "\t \t");
    Console.Write(pro.MDate.ToLongDateString() + "\t \t");
    Console.Write(pro.EDate.ToLongDateString());

    Console.WriteLine("\n");
}

