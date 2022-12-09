double Celsius = 0;
double Fahrenheit = 0;
double Kelvin = 0;
double Inches = 0;
double Feet = 0;
double Yards = 0;
double Seconds = 0;
double Minutes = 0;
double Hours = 0;
int choice = 0;
(Temperature, double) CelsiusToFahrenheit()
{
    (Temperature, double) Temp = (Temperature.Fahrenheit, Fahrenheit);
    Fahrenheit = (Celsius * 1.8) + 32.00;
    Temp.Item2 = Fahrenheit;
    return Temp;
}
(Temperature, double) CelsiusToKelvin()
{
    (Temperature, double) Temp = (Temperature.Kelvin, Kelvin);
    Kelvin = Celsius + 273.15;
    Temp.Item2 = Kelvin;
    return Temp;
}
(Temperature, double) FahrenheitToCelsius()
{
    (Temperature, double) Temp = (Temperature.Celsius, Celsius);
    Celsius = (Fahrenheit - 32) * 0.56;
    Temp.Item2 = Celsius;
    return Temp;
}
(Temperature, double) FahrenheitToKelvin()
{
    (Temperature, double) Temp = (Temperature.Kelvin, Kelvin);
    Kelvin = (Fahrenheit - 32.00) * 0.56 + 273.15;
    Temp.Item2 = Kelvin;
    return Temp;
}
(Temperature, double) KelvinToFahrenheit()
{
    (Temperature, double) Temp = (Temperature.Fahrenheit, Fahrenheit);
    Fahrenheit = (Kelvin - 273.15) * 1.8 + 32;
    Temp.Item2 = Fahrenheit;
    return Temp;
}
(Temperature, double) KelvinToCelsius()
{
    (Temperature, double) Temp = (Temperature.Celsius, Celsius);
    Celsius = Kelvin - 273.15;
    Temp.Item2 = Celsius;
    return Temp;
}
(Length, double) InchsToFeet()
{
    (Length, double) Distance = (Length.Feet, Feet);
    Feet = Inches / 12;
    Distance.Item2 = Feet;
    return Distance;
}
(Length, double) InchsToYards()
{
    (Length, double) Distance = (Length.Yard, Yards);
    Yards = Inches / 36;
    Distance.Item2 = Yards;
    return Distance;
}
(Length, double) FeetToInchs()
{
    (Length, double) Distance = (Length.Inch, Inches);
    Inches = Feet * 12;
    Distance.Item2 = Inches;
    return Distance;
}
(Length, double) FeetToYards()
{
    (Length, double) Distance = (Length.Yard, Yards);
    Yards = Feet / 3;
    Distance.Item2 = Yards;
    return Distance;
}
(Length, double) YardsToFeet()
{
    (Length, double) Distance = (Length.Feet, Feet);
    Feet = Yards * 3;
    Distance.Item2 = Feet;
    return Distance;
}
(Length, double) YardToInchs()
{
    (Length, double) Distance = (Length.Inch, Inches);
    Inches = Feet * 36;
    Distance.Item2 = Inches;
    return Distance;
}
(Time, double) SecondsToMinutes()
{
    (Time, double) Chronology = (Time.Minutes, Minutes);
    Minutes = Seconds / 60;
    Chronology.Item2 = Minutes;
    return Chronology;
}
(Time, double) SecondsToHours()
{
    (Time, double) Chronology = (Time.Hours, Hours);
    Hours = Seconds / 3600;
    Chronology.Item2 = Hours;
    return Chronology;
}
(Time, double) MinutesToSeconds()
{
    (Time, double) Chronology = (Time.Seconds, Seconds);
    Seconds = Minutes * 60;
    Chronology.Item2 = Seconds;
    return Chronology;
}
(Time, double) MinutesToHours()
{
    (Time, double) Chronology = (Time.Hours, Hours);
    Hours = Minutes / 60;
    Chronology.Item2 = Hours;
    return Chronology;
}
(Time, double) HoursToMinutes()
{
    (Time, double) Chronology = (Time.Minutes, Minutes);
    Minutes = Hours * 60;
    Chronology.Item2 = Minutes;
    return Chronology;
}
(Time, double) HoursToSeconds()
{
    (Time, double) Chronology = (Time.Seconds, Seconds);
    Seconds = Hours * 3600;
    Chronology.Item2 = Seconds;
    return Chronology;
}
int Exit = 0;
HoursToSeconds();
while (Exit < 1)
{
    Console.WriteLine(" please pick a conversion by selecting its coresponding number. \n 1: CelsiusToFahrenheit \n 2: CelsiusToKelvin \n 3: FahrenheitToCelsius \n 4: FarenheitToKelvin \n 5: KelvinToFahrenheit \n 6: KelvinToCelsius");
    Console.WriteLine(" 7: InchsToFeet \n 8: InchsToYards \n 9: FeetToInchs \n 10: FeetToYards \n 11: YardsToFeet \n 12: YardToInchs ");
    Console.WriteLine(" 13: SecondsToMinutes \n 14: SecondsToHours \n 15: MinutesToSeconds \n 16: MinutesToHours \n 17: HoursToMinutes \n 18: HoursToSeconds \n oExit");
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Please choose a how much to convert");
            Celsius = int.Parse(Console.ReadLine());
           Console.WriteLine(CelsiusToFahrenheit());
           Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 2:
            Console.WriteLine("Please choose a how much to convert");
            Celsius = int.Parse(Console.ReadLine());
            Console.WriteLine(CelsiusToKelvin());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 3:
            Console.WriteLine("Please choose a how much to convert");
            Fahrenheit = int.Parse(Console.ReadLine());
            Console.WriteLine(FahrenheitToCelsius());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 4:
            Console.WriteLine("Please choose a how much to convert");
            Fahrenheit = int.Parse(Console.ReadLine());
            Console.WriteLine(FahrenheitToKelvin());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 5:
            Console.WriteLine("Please choose a how much to convert");
            Kelvin = int.Parse(Console.ReadLine());
            Console.WriteLine(KelvinToFahrenheit());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 6:
            Console.WriteLine("Please choose a how much to convert");
            Kelvin = int.Parse(Console.ReadLine());
           Console.WriteLine( KelvinToCelsius());
           Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 7:
            Console.WriteLine("Please choose a how much to convert");
            Inches = int.Parse(Console.ReadLine());
            Console.WriteLine(InchsToFeet());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 8:
            Console.WriteLine("Please choose a how much to convert");
            Inches = int.Parse(Console.ReadLine());
            Console.WriteLine(InchsToYards());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 9:
            Console.WriteLine("Please choose a how much to convert");
            Feet = int.Parse(Console.ReadLine());
            Console.WriteLine(FeetToInchs());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 10:
            Console.WriteLine("Please choose a how much to convert");
            Feet = int.Parse(Console.ReadLine());
            Console.WriteLine(FeetToYards());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 11:
            Console.WriteLine("Please choose a how much to convert");
            Yards = int.Parse(Console.ReadLine());
            Console.WriteLine(YardsToFeet());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 12:
            Console.WriteLine("Please choose a how much to convert");
            Yards = int.Parse(Console.ReadLine());
            Console.WriteLine(YardToInchs());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 13:
            Console.WriteLine("Please choose a how much to convert");
            Seconds = int.Parse(Console.ReadLine());
            Console.WriteLine(SecondsToMinutes());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 14:
            Console.WriteLine("Please choose a how much to convert");
            Seconds = int.Parse(Console.ReadLine());
            Console.WriteLine(SecondsToHours());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 15:
            Console.WriteLine("Please choose a how much to convert");
            Minutes = int.Parse(Console.ReadLine());
            Console.WriteLine(MinutesToSeconds());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 16:
            Console.WriteLine("Please choose a how much to convert");
            Minutes = int.Parse(Console.ReadLine());
            Console.WriteLine(MinutesToHours());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 17:
            Console.WriteLine("Please choose a how much to convert");
            Hours = int.Parse(Console.ReadLine());
            Console.WriteLine(HoursToMinutes());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 18:
            Console.WriteLine("Please choose a how much to convert");
            Hours = int.Parse(Console.ReadLine());
            Console.WriteLine(HoursToSeconds());
            Console.WriteLine("Please press enter to try another option");
           Console.ReadKey();
            break;
        case 19:
        Exit++;
        break;
    }
}
enum Temperature
{
    Celsius, Fahrenheit, Kelvin
}
enum Length
{
    Inch, Feet, Yard
}
enum Time
{
    Seconds, Minutes, Hours
}