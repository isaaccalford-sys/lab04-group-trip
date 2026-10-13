/* 
* Name: Isaac Alford
* Course: CSCI-1250, Section 201
* Assignment: Lab 04, The Group Trip
* Date: October 12, 2026
* Discription: Revising lab 2 with methods and arrays.
*/
using System.Security;
using System.Security.Cryptography;
//constants 
const Double amountOfSlices = 8;
const Double taxRate = .18;

// arrays
string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

//part 1: Road Trip

//Questions
System.Console.WriteLine();
Console.Write("How many miles are you driving? ");
Double miles = Convert.ToDouble(Console.ReadLine());

Console.Write("How many miles per gallon can your car go? ");
Double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How much did you pay for gas? ");
Double pricePerGallon = Convert.ToDouble(Console.ReadLine());
  
System.Console.Write("How many pizzas do you get? ");
 Double amountOfPizzas= Convert.ToDouble(Console.ReadLine());

System.Console.Write("What is the price per pizza? ");
 Double pricePerPizza = Convert.ToDouble(Console.ReadLine());


//calculations

//fuel
double fuelCost = FuelCost(miles, milesPerGallon, pricePerGallon);

//pizza
Double totalSlices = amountOfPizzas * amountOfSlices;
Double slicesPerPerson =  totalSlices / names.Length;
Double pizzaCost =amountOfPizzas * pricePerPizza;

//Trip total
Double tripTotal = fuelCost + pizzaCost;
Double amountOwed = tripTotal / names.Length;

//results
System.Console.WriteLine();
System.Console.WriteLine("=== Part 1: The Trip ===");
System.Console.WriteLine("Fuel cost " + fuelCost.ToString("C") );
System.Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));



// Part 2: The Group 


//math
double slicesEach = totalSlices / names.Length;
double costPerPerson = tripTotal / names.Length;

//results
System.Console.WriteLine();
System.Console.WriteLine("=== Part 2: The Group ===");
System.Console.WriteLine($"People Going: {names.Length}");
System.Console.WriteLine($"Slices each: {slicesEach.ToString("F1")}");
System.Console.WriteLine($"Cost per person: {costPerPerson.ToString("C")}");

// Part 3: The Report 

System.Console.WriteLine();
System.Console.WriteLine("=== Part 3: Who Works How Long ===");

double totalHours = 0;
double totalPay = 0;
double longestHours = 0;

for (int i = 0; i < names.Length; i++)
{
    double takeHomePay = TakeHomePay(hoursWorked[i], hourlyRates[i], taxRate);
    double takeHomePayPerHoursWorked = takeHomePay / hoursWorked[i];
    double hoursNeeded = HoursToCover(costPerPerson, takeHomePayPerHoursWorked);

    longestHours = Math.Max(longestHours, hoursNeeded);
    totalHours += hoursWorked[i];
    totalPay += takeHomePay;

    Console.WriteLine($"{names[i]}: takes home {takeHomePay.ToString("C")} for {hoursWorked[i]} hours, {takeHomePayPerHoursWorked.ToString("C")} per hour, must work {hoursNeeded.ToString("F2")} hours");
}

//printing 
System.Console.WriteLine();
System.Console.WriteLine($"Total hours worked: {totalHours}");
System.Console.WriteLine($"Total take home pay: {totalPay.ToString("C")}");
System.Console.WriteLine($"Longest anyone must work: {longestHours.ToString("F2")}");

//Methods 
//finds the total cost of fuel for the trip
static double FuelCost (double miles, double milesPerGallon, double pricePerGallon)
{
    Double gallonsNeeded = miles / milesPerGallon;
   return gallonsNeeded * pricePerGallon;
}

//finds the money taken home out of the paycheck
static double TakeHomePay (double hours, double hourlyRate, double taxRate)
{
    Double grossPay = hours * hourlyRate;
    Double taxWithheld = grossPay * taxRate;
    return grossPay - taxWithheld;
}
//finds how many hours of work are needed to pay for the trip
static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return  amountOwed / takeHomePerHour;
}