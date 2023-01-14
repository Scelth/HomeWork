using IMag;
using Mag;
using System.Text.Json;

Console.Write("What do you want?\n" +
    "1 - Serialization\n" +
    "2 - DeSerialization\n" +
    "Your choice - ");
short ch = Int16.Parse(Console.ReadLine());

#region Serialization
if (ch == 1)
{
    Magazine magazine = new();
    IMagazineable magazineable = magazine;

    Console.Write("\nEnter magazine name - "); // Это красиво когда мы вводим данные, но длинно.
    magazineable.Name = Console.ReadLine();

    Console.Write("Enter the publishing house name - ");
    magazineable.Publishing_house = Console.ReadLine();

    Console.Write("Enter the magazine release year - ");
    magazineable.Year = Int16.Parse(Console.ReadLine());

    Console.Write("Enter the number of pages - ");
    magazineable.Pages = Int16.Parse(Console.ReadLine());

    using FileStream fs = new("Magazine.json", FileMode.OpenOrCreate);
    JsonSerializer.Serialize(fs, magazineable);
}
#endregion

#region DeSerialization
else if (ch == 2)
{
    using FileStream fr = new("Magazine.json", FileMode.Open);

    var mag = JsonSerializer.Deserialize<Magazine>(fr);

    Console.WriteLine(mag);
}
#endregion