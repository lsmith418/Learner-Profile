//Enter first name:
using System.Transactions;

Console.WriteLine("Enter your first name:   ");
string firstname = Console.ReadLine()?.Trim() ?? "";

//Enter last name
Console.WriteLine("Enter your last name:   ");
string lastname = Console.ReadLine()?.Trim() ?? "";

//Enter email
Console.WriteLine("Enter your email address:   ");
string email = Console.ReadLine()?.Trim() ?? "";

//Enter your age
Console.WriteLine("Enter your age:   ");
int age = int.Parse(Console.ReadLine() ?? "0");

//Opt-in for marketing
Console.WriteLine("Opt-in for marketing. Enter Y for yes or N for no:  ");
string input = Console.ReadLine() ?? "";
bool marketingOptIn = input.Equals( "Y", StringComparison.OrdinalIgnoreCase);

//Enter your height in cm:
Console.WriteLine("Enter your height in cm:   ");
double heightCm = double.Parse(Console.ReadLine() ?? "0");

//Enter your weight in kg:
Console.WriteLine("Enter your weight in kg:    ");

double weightKg = double.Parse(Console.ReadLine() ?? "0");


//Profile Summary

//Name: 

//Email: 

//Age:

//Marketing Opt-in: True or False

//Height:  cm

//Weight:  kg

string summary = $""" 

    ---User Summary---
    Full Name:           {firstname} {lastname}
    Email Address:       {email}
    Age:                 {age} years old
    Marketing Opt in:    {(marketingOptIn ? "Yes" : "No")}
    Height:              {heightCm:F1} cm
    Weight:              {weightKg:F1} kg
    -----------------------------------

""";

Console.WriteLine(summary);
