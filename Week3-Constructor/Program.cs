
using Week3_Constructor;

Bebek bebek =  new Bebek();//Creating a baby using default constructor

bebek.Name = "Defne";
bebek.Surname = "Gecimli";

Console.WriteLine($"Bebegin adi : {bebek.Name} Soyadi : {bebek.Surname} Dogum gunu : {bebek.Birthday}");

Bebek newBebek = new Bebek("Yavuz","Gecimli");//Creating a baby using the alternative constructor

Console.WriteLine($"Bebegin adi : {newBebek.Name} Soyadi : {newBebek.Surname} Dogum gunu : {newBebek.Birthday}");

Console.ReadKey();

