// Chap6
for(var i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("-----------------------");

for(var i2 = 1; i2 <= 10; i2++)
{
    Console.WriteLine(i2);
}

Console.WriteLine("-----------------------");

string[] favoriteName = ["Boss", "Bob","Charlie", "Susie"];

for(var i =0; i < favoriteName.Length; i++)
{
    Console.WriteLine(favoriteName[i]);
}

Console.WriteLine("-----------------------");

foreach(var favName in favoriteName)
{
    Console.WriteLine(favName);
}

Console.WriteLine("-----------------------");

favoriteName.ToList().ForEach((i) =>{
    Console.WriteLine("ForEach:" + i);
});

Console.WriteLine("-----------------------");

Array.ForEach(favoriteName, e => Console.WriteLine("Array.ForEach:" + e));