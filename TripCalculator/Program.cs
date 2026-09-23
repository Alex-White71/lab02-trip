/*
* Name: Alex White
* Course: CSCI 1250, Section 002
* Assignment: Lab 02, Trip Calculator
* Date: September 23, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/
// Calculates the gallons needed and fuel cost for the road trip.
Console.WriteLine("How many miles is the trip both ways? ");
double milesForTheTrip = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the miles per gallon of the car during the trip? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("How much is the Price per gallon of gas? ");
double price = Convert.ToDouble(Console.ReadLine());
double gallonsNeeded = milesForTheTrip/milesPerGallon;
double fuelCost = gallonsNeeded * price;
Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
// Calculates total slices, slices per person, and pizza cost for the pizza party.
Console.WriteLine("How many people are going to be there? ");
double peopleCount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("How many pizzas are needed? ");
int pizzaCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How much does a pizza cost? ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());
const int NUMBERS_OF_SLICES = 8;
double totalSlices = pizzaCount * NUMBERS_OF_SLICES;
double slicesPerPerson = totalSlices/peopleCount;
double pizzaCost = pizzaCount * pizzaPrice;
Console.WriteLine ("Total slices: " + totalSlices);
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
// calculates gross pay, tax withheld, and take home pay for a paycheck
Console.WriteLine("How many hours did you worked this week? ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the hourly rate? ");
double hourlyRate = Convert.ToDouble(Console.ReadLine());
const double TAX_RATE = .18;
double grossPay = hourlyRate * hoursWorked;
double taxWithheld = grossPay * TAX_RATE;
double takeHome = grossPay - taxWithheld;
Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHome.ToString("C"));
// calculates the trip total, cost per person, take home pay per hour, and the hours needed to work for the whole trip.
double tripTotal = fuelCost + pizzaCost;
double costPerPerson = tripTotal/peopleCount;
double takeHomePerHour = takeHome/hoursWorked;
double minHoursWork = costPerPerson/takeHomePerHour;
Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + takeHomePerHour.ToString("C"));
Console.WriteLine("Hours you must work to cover you share: " + minHoursWork.ToString("F2"));