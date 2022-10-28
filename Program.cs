
void Celsius()
{
    Console.WriteLine("What is your starting temperature?");
    int StartingNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("What units would you like to convert to?");
    Console.WriteLine("1. Fahrenheit\n2. Kelvin");
    int choice = int.Parse(Console.ReadLine());
   
    if(choice == 1)
    {
        TemperConversion.Degree = (StartingNumber * 1.8) + 32;
        TemperConversion.Unit = "Fahrenheit";
        Console.WriteLine($"You're ending temp is {TemperConversion:00.00}");
        
    }
   
    if(choice == 2)
    {
        TemperConversion.Degree = (StartingNumber + 273);
        TemperConversion.Unit = "Kelvin";
        Console.WriteLine($"You're ending temp is {TemperConversion:00.00}");
        
    }
    
    }

    void Fahrenheit()
    {
        Console.WriteLine("What is your starting temperature?");
    int StartingNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("What units would you like to convert to?");
    Console.WriteLine("1. Celsius\n2. Kelvin");
    int choice = int.Parse(Console.ReadLine());

    if(choice == 1);

    }

   