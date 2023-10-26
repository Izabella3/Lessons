Console.WriteLine("Enter the planet name");
string planet = Console.ReadLine();
if (planet.ToUpper() == "EARTH")
{
    Console.WriteLine("Distance from the Sun: 149.27 million km, Color: blue");
}
else if (planet.ToUpper() == "VENUS")
{
    Console.WriteLine("Distance from the Sun: 108.01 million km, Color: orange");
}
else if (planet.ToUpper() == "MERCURY")
{
    Console.WriteLine("Distance from the Sun: 58 million km,Color: dark gray");
}
else if (planet.ToUpper() == "SATURN")
{
    Console.WriteLine("Distance from the Sun: 1.4586 billion km, Color: yellowish-brown");
}
else if (planet.ToUpper() == "MARS")
{
    Console.WriteLine("Distance from the Sun: 401 million km, Color: red");
}
else if (planet.ToUpper() == "URANUS")
{
    Console.WriteLine("Distance from the Sun: 2.9 billion km, Color: blue-green");
}
else if (planet.ToUpper() == "JUPITER")
{
    Console.WriteLine("Distance from the Sun: 743.53 million km, Color: white-orange");
}
else if (planet.ToUpper() == "NEPTUN")
{
    Console.WriteLine("Distance: 4.47 billion km, Color: blue");
}
else
{
    Console.WriteLine("Please enter a valid planet name.");
}

Console.WriteLine("Enter the planet name");
string planet1 = Console.ReadLine();
switch (planet1.ToUpper())
{
    case "EARTH":
        Console.WriteLine("Distance from the Sun: 149.27 million km, Color: blue");
        break;
    case "VENUS":
        Console.WriteLine("Distance from the Sun: 108.01 million km, Color: orange");
        break;
    case "MERCURY":
        Console.WriteLine("Distance from the Sun: 58 million km, Color: dark gray");
        break;
    case "SATURN":
        Console.WriteLine("Distance from the Sun: 1.4586 billion km, Color: yellowish-brown");
        break;
    case "MARS":
        Console.WriteLine("Distance from the Sun: 401 million km, Color: red");
        break;
    case "URANUS":
        Console.WriteLine("Distance from the Sun: 2.9 billion km, Color: blue-green");
        break;
    case "JUPITER":
        Console.WriteLine("Distance from the Sun: 743.53 million km, Color: white-orange");
        break;
    case "NEPTUN":
        Console.WriteLine("Distance: 4.47 billion km, Color: blue");
        break;
    default:
        Console.WriteLine("Please enter a valid planet name.");
        break;
}
Console.ReadKey();