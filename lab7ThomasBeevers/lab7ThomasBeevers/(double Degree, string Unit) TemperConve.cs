 (double Degree, string Unit) TemperConversion = (0, "hey");
(double Length, string Unit) LongConversion = (0, "hey");
(double Time, string Unit) TimeConversion = (0, "hey");
Console.Clear();
void TempConversion(){
    
    Console.WriteLine("What units do you have?");
    Console.WriteLine("1. Celsius\n2. Fahrenheit\n3. Kelvin");
    int UnitsStart = int.Parse(Console.ReadLine());
    switch(UnitsStart){
        case 1:
        Celsius();
        break;
        case 2:
        Fahrenheit();
        break;
        case 3:
        Kelvin();
        break;
        default:
        Console.WriteLine("I can't read that.");
        TempConversion();
        break;
    }
   
}
void Celsius(){
    Console.WriteLine("What is your starting temperature?");
    int StartingNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("What units would you like to convert to?");
    Console.WriteLine("1. Fahrenheit\n2. Kelvin");
    int choice = int.Parse(Console.ReadLine());
    if(choice == 1){
        TemperConversionDegree = (StartingNumber * 1.8) + 32;
        TemperConversionUnit = "Fahrenheit";
        Console.WriteLine($"You're ending temp is {TemperConversinDegree + TemperConversionUnit}");  
    }
    
    if(choice == 2){
        TemperConversion.Degree = (StartingNumber + 273);
        TemperConversion.Unit = "Kelvin";
        Console.WriteLine($"You're ending temp is {TemperConversion:00.00}");
    }
    
}
void Fahrenheit(){
    Console.WriteLine("What is your starting temperature?");
    int StartingNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("What units would you like to convert to?");
    Console.WriteLine("1. Celsius\n2. Kelvin");
    int choice = int.Parse(Console.ReadLine());
    if(choice == 1){
        TemperConversion.Degree = (StartingNumber - 32) / 1.8;
        TemperConversion.Unit = "Celsius";
        Console.WriteLine($"You're ending temp is {TemperConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Fahrenheit");
    }
    if(choice == 2){
        TemperConversion.Degree = (((StartingNumber - 32) / 1.8 ) - 273);
        TemperConversion.Unit = "Kelvin";
        Console.WriteLine($"You're ending temp is {TemperConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Fahrenheit");
    }
    else{
        Console.WriteLine("I can't work with this.");
        Fahrenheit();
    }
}
void Kelvin(){
    Console.WriteLine("What is your starting temperature?");
    int StartingNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("What units would you like to convert to?");
    Console.WriteLine("1. Celsius\n2. Farneheit");
    int choice = int.Parse(Console.ReadLine());
    if(choice == 1){
        TemperConversion.Degree = (StartingNumber - 273);
        TemperConversion.Unit = "Celsius";
        Console.WriteLine($"You're ending temp is {TemperConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Kelvin");
    }
    if(choice == 2){
        TemperConversion.Degree = (((StartingNumber - 273) * 1.8) + 32);
        TemperConversion.Unit = "Fahrenheit";
        Console.WriteLine($"You're ending temp is {TemperConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Kelvin");
    }
    else{
        Console.WriteLine("I'm sorry, but I can't read that");
        Kelvin();
    }
}



void LengthConversion(){
    
    Console.WriteLine("What units do you have?");
    Console.WriteLine("1. inches\n2. Feet\n3. Yards");
    int UnitsStart = int.Parse(Console.ReadLine());
    switch(UnitsStart){
        case 1:
        Inches();
        break;
        case 2:
        Feet();
        break;
        case 3:
        Yards();
        break;
        default:
        Console.WriteLine("I can't read that.");
        LengthConversion();
        break;
    }
   
}
void Inches(){
    Console.WriteLine("What is your starting Length?");
    int StartingNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("What units would you like to convert to?");
    Console.WriteLine("1. Feet\n2. Yards");
    int choice = int.Parse(Console.ReadLine());
    if(choice == 1){
        LongConversion.Length = StartingNumber / 12;
        LongConversion.Unit = "Feet";
        Console.WriteLine($"You're ending temp is {LongConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Inches");
    }
    if(choice == 2){
        TemperConversion.Degree = (StartingNumber / 36);
        TemperConversion.Unit = "Yards";
        Console.WriteLine($"You're ending temp is {LongConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Inches");
    }
    else{
        Console.WriteLine("I'm sorry, but I can't read that");
        Inches();
    }
}
void Feet(){
    Console.WriteLine("What is your starting Length?");
    int StartingNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("What units would you like to convert to?");
    Console.WriteLine("1. Inches\n2. Yards");
    int choice = int.Parse(Console.ReadLine());
    if(choice == 1){
        LongConversion.Length = (StartingNumber * 12);
        LongConversion.Unit = "Inches";
        Console.WriteLine($"You're ending temp is {LongConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Feet");
    }
    if(choice == 2){
        LongConversion.Length = (StartingNumber  / 3);
        LongConversion.Unit = "Yards";
        Console.WriteLine($"You're ending temp is {LongConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Feet");
    }
    else{
        Console.WriteLine("I'm sorry, but I can't read that");
        Feet();
    }
}
void Yards(){
    Console.WriteLine("What is your starting Length?");
    int StartingNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("What units would you like to convert to?");
    Console.WriteLine("1. Inches\n2. Feet");
    int choice = int.Parse(Console.ReadLine());
    if(choice == 1){
        LongConversion.Length = (StartingNumber * 36);
        LongConversion.Unit = "Inches";
        Console.WriteLine($"You're ending temp is {LongConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Yards");
    }
    if(choice == 2){
        LongConversion.Length = StartingNumber * 3;
        LongConversion.Unit = "Feet";
        Console.WriteLine($"You're ending temp is {LongConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Yards");
    }
    else{
        Console.WriteLine("I'm sorry, but I can't read that");
        Yards();
    }
}



void TimeCon(){
    Console.WriteLine("What units do you have?");
    Console.WriteLine("1. Seconds\n2. Minutes\n3. Hours");
    int UnitsStart = int.Parse(Console.ReadLine());
    switch(UnitsStart){
        case 1:
        Seconds();
        break;
        case 2:
        Minutes();
        break;
        case 3:
        Hours();
        break;
        default:
        Console.WriteLine("I can't read that.");
        TimeCon();
        break;
    }
}
void Seconds(){
    Console.WriteLine("What is your starting Time?");
    int StartingNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("What units would you like to convert to?");
    Console.WriteLine("1. Minutes\n2. Hours");
    int choice = int.Parse(Console.ReadLine());
    if(choice == 1){
        TimeConversion.Time = StartingNumber * 60;
        TimeConversion.Unit = "Minutes";
        Console.WriteLine($"You're ending temp is {TimeConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Seconds");
    }
    if(choice == 2){
        TimeConversion.Time = (StartingNumber * 3600);
        TimeConversion.Unit = "Hours";
        Console.WriteLine($"You're ending temp is {TimeConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Seconds");
    }
    else{
        Console.WriteLine("I'm sorry, but I can't read that");
        Seconds();
    }
}
void Minutes(){
    Console.WriteLine("What is your starting Time?");
    int StartingNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("What units would you like to convert to?");
    Console.WriteLine("1. Seconds\n2. Hours");
    int choice = int.Parse(Console.ReadLine());
    if(choice == 1){
        TimeConversion.Time = (StartingNumber / 12);
        TimeConversion.Unit = "Seconds";
        Console.WriteLine($"You're ending temp is {TimeConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Minutes");
    }
    if(choice == 2){
        TimeConversion.Time = StartingNumber / 60;
        TimeConversion.Unit = "Hours";
        Console.WriteLine($"You're ending temp is {TimeConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Minutes");
    }
    else{
        Console.WriteLine("I'm sorry, but I can't read that");
        Minutes();
    }
}
void Hours(){
    Console.WriteLine("What is your starting Time?");
    int StartingNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("What units would you like to convert to?");
    Console.WriteLine("1. Seconds\n2. Minutes");
    int choice = int.Parse(Console.ReadLine());
    if(choice == 1){
        TimeConversion.Time = (StartingNumber * 3600);
        TimeConversion.Unit = "Seconds";
        Console.WriteLine($"You're ending temp is {TimeConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Hours");
    }
    if(choice == 2){
        TimeConversion.Time = StartingNumber *60;
        TimeConversion.Unit = "Minutes";
        Console.WriteLine($"You're ending temp is {TimeConversion:00.00}");
        Console.WriteLine($"You started with {StartingNumber} Hours");
    }
    else{
        Console.WriteLine("I'm sorry, but I can't read that");
        Hours();
    }
}



PromptingFunction();
void PromptingFunction(){
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Temperature Conversions\n2. Length Conversions\n3. Time Converesions");
    int response = int.Parse(Console.ReadLine());
    switch(response){
        case 1:
        TempConversion();
        break;
        case 2:
        LengthConversion();
        break;
        case 3:
        TimeCon();
        break;
        default:
        PromptingFunction();
        break;
    }
}
enum  temperature {Celsius, Fahrenheit, Kelvin};
enum Length {inch, feet, yard};
enum time {seconds, minutes, hours};