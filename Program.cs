// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zadej poloměr kruhu (cm):");
float a = float.Parse (Console.ReadLine());

float obvod = 2 * 3.1415f * a;
float obsah = 3.1415f * a * a;

Console.WriteLine("Obvod zadaného kruhu je: " + obvod + " cm");
Console.WriteLine("Jeho obsah je "  + obsah + " cm^2");
Console.ReadKey();