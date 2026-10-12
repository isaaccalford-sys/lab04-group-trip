/* 
* Name: Isaac Alford
* Course: CSCI-1250, Section 201
* Assignment: Lab 04, The Group Trip
* Date: October 12, 2026
* Discription: reviseing lab 2 with methods.
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
Console.Write("How many miles are you driving ");
Double miles = Convert.ToDouble(Console.ReadLine());

Console.Write("How many miles per gallon can your car go? ");
Double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How much did you pay for gas? ");
Double pricePerGallon = Convert.ToDouble(Console.ReadLine());
  
System.Console.Write("How many pizzas do you get? ");
 Double  amountOfPizzas= Convert.ToDouble(Console.ReadLine());

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



//print
// System.Console.WriteLine();

// System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));


// System.Console.WriteLine();

//part: 2 pizza


//calculations 
 
  
   

//print


// System.Console.WriteLine("Total slices: " + totalSlices.ToString("F2"));
// System.Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));





//print



// System.Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
// System.Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
// System.Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));


// part: 4 total trip




//Double takeHomePayPerHour = takeHomePay / hoursWorked;


//print


// System.Console.WriteLine("Cost per person: " + amountOwed.ToString("C"));
// System.Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("F2"));
// System.Console.WriteLine("Hours you must work in order to cover your share: " + hoursYouMustWork.ToString("C"));


//Methods 
static double FuelCost (double miles, double milesPerGallon, double pricePerGallon)
{
    Double gallonsNeeded = miles / milesPerGallon;
   return gallonsNeeded * pricePerGallon;
}

static double TakeHomePay (double hours, double hourlyRate, double taxRate)
{
    Double grossPay = hours * hourlyRate;
    Double taxWithheld = grossPay * taxRate;
    return grossPay - taxWithheld;
}


static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return  amountOwed / takeHomePerHour;
}