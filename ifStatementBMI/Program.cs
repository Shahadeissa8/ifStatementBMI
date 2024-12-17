// Shahad Eissa
// Calculate BMI:
Console.WriteLine("enter you weight: ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter your height in cm: ");
double height = Convert.ToDouble(Console.ReadLine());
//double height = Convert.ToDouble(Console.ReadLine())/100;
//height = height/100;
double heightInMeter = height / 100;
double BMI = (weight / Math.Pow(heightInMeter,2) );
//double BMI = weight / (height * height);
string BMIState;
Console.WriteLine("BMI is: " + BMI);

// BMI state:
if (BMI < 18.5)
{
    BMIState = ("under weight");
    Console.WriteLine(BMIState);
}
else if (BMI >= 18.5 && BMI <= 24.9)
{
    BMIState = ("healthy");
    Console.WriteLine(BMIState);
}
else if (BMI >= 25 && BMI <= 29.9)
{
    BMIState = ("over weight");
    Console.WriteLine(BMIState);
} 
else if (BMI >= 18.5 && BMI <= 24.9)
{
    BMIState = ("obese");
    Console.WriteLine(BMIState);
}
//instead of printing it in each one we could just write the print function at the end using BMIState

// BMI state by age
Console.WriteLine("enter your age");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 19 && age <= 24)
{
    if (BMI >= 19 && BMI <= 24)
    {
        BMIState = ("healthy");
        Console.WriteLine(BMIState);
    }
    else
    {
        BMIState = ("not healthy");
        Console.WriteLine(BMIState);
    }
}
else if (age >= 25 && age <= 34)
{
    if (BMI >= 20 && BMI <= 25)
    {
        BMIState = ("healthy");
        Console.WriteLine(BMIState);
    }
    else
    {
        BMIState = ("not healthy");
        Console.WriteLine(BMIState);
    }
}
else if (age >= 35 && age <= 44)
{
    if (BMI >= 21 && BMI <= 26)
    {
        BMIState = ("healthy");
        Console.WriteLine(BMIState);
    }
    else
    {
        BMIState = ("not healthy");
        Console.WriteLine(BMIState);
    }
}
else if (age >= 45 && age <= 54)
{
    if (BMI >= 22 && BMI <= 27)
    {
        BMIState = ("healthy");
        Console.WriteLine(BMIState);
    }
    else
    {
        BMIState = ("not healthy");
        Console.WriteLine(BMIState);
    }
}
else if (age >= 55 && age <= 64)
{
    if (BMI >= 23 && BMI <= 28)
    {
        BMIState = ("healthy");
        Console.WriteLine(BMIState);
    }
    else
    {
        BMIState = ("not healthy");
        Console.WriteLine(BMIState);
    }
}
else if (age >= 65)
{
    if (BMI >= 24 && BMI <= 29)
    {
        BMIState = ("healthy");
        Console.WriteLine(BMIState);
    }
    else
    {
        BMIState = ("not healthy");
        Console.WriteLine(BMIState);
    }
}
//if ((age>=25 && age <=34)&&(BMI >= 20 && BMI <=25)) we can use this instead
