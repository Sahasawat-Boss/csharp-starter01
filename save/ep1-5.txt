using System.Text;

Console.WriteLine("Hello, C#");
//Console.WriteLine >> not a variable, will not store anywhere

// var numberOfStudents = "10";
// Console.WriteLine(numberOfStudents);
//var >> variable, will store the value

// string name = "Boss";
// Console.WriteLine(name);

//long BankMoneyAmount = 500000000000;

//var charchar = "A";

string petFish = "Goldfish";
Console.WriteLine(petFish);

//Concatenation
petFish = "a small " + petFish;
Console.WriteLine(petFish);

//Template Literal >> for complex strings
Console.WriteLine($"My pet is {petFish}");

//CRUD
// READ
// Console.WriteLine()

//UPDATE
string newPetFish = petFish.Replace("Goldfish", "Dog");
Console.WriteLine(newPetFish);

//DELETE
// String Builder
StringBuilder newCrustacean = new StringBuilder();
newCrustacean.Append("fiddler crab");
Console.WriteLine(newCrustacean);   // Output: fiddler crab
newCrustacean.Remove(0, 8);
Console.WriteLine(newCrustacean);   // Output: crab