using System;

namespace Cheney_CashFlowManager
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoCenter Info = new InfoCenter();
            ConsoleKeyInfo keyInfo;
            bool Escape = false;
            string FirstName;
            string LastName;
            string SSN;
            string PartNumber;
            string PartDescription;
            decimal WeeklySalary;
            decimal HourlyWage;
            decimal Price;
            int HoursWorked;
            int Quantity;
            Random random = new Random(DateTime.Now.Millisecond);
            IPayable IE;
            IPayable HE;
            IPayable SE;
            SE = new SalariedEmployee("Dean", "Martin", "323-23-2323", 800.32M);
            Info.Add(SE);
            SE = new SalariedEmployee("Frank", "Sinatra", "464-64-6464", 850.95M);
            Info.Add(SE);
            SE = new SalariedEmployee("Sammy", "Davis Jr.", "717-17-1717", 820.26M);
            Info.Add(SE);
            HE = new HourlyEmployee("Joey", "Bishop", "595-95-9595", 14.32M, 43);
            Info.Add(HE);
            HE = new HourlyEmployee("Peter", "Lawford", "282-82-8282", 16.54M, 38);
            Info.Add(HE);
            HE = new HourlyEmployee("Nathaniel", "Coles", "606-06-0606", 17.43M, 40);
            Info.Add(HE);
            IE = new Invoice(random.Next(99999, 1000000) + "_3725", 4, "Photon Pack", 5500M);
            Info.Add(IE);
            IE = new Invoice(random.Next(99999, 1000000) + "_1860", 1, "The One Ring", 10000M);
            Info.Add(IE);
            IE = new Invoice(random.Next(99999, 1000000) + "_9283", 5, "Wonka's Chocolate Bars", 10M);
            Info.Add(IE);
            do
            {
                Console.WriteLine("Choose from the following Options");
                Console.WriteLine("1. Add a new Employee");
                Console.WriteLine("2. Add a new Invoice");
                Console.WriteLine("3. Print Weekly Cash Flow Analysis");
                Console.WriteLine("4. End Program");
                keyInfo = Console.ReadKey();
                Console.Clear();
                if (keyInfo.Key == ConsoleKey.NumPad1 || keyInfo.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Please select which type of Employee you are adding");
                    Console.WriteLine("1. Salaried Employee");
                    Console.WriteLine("2. Hourly Employee");
                    keyInfo = Console.ReadKey();
                    Console.Clear();
                    if (keyInfo.Key == ConsoleKey.NumPad1 || keyInfo.Key == ConsoleKey.D1)
                    {
                        Console.WriteLine("Enter First Name");
                        FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        LastName = Console.ReadLine();
                        Console.WriteLine("Enter SSN");
                        SSN = Console.ReadLine();
                        Console.WriteLine("Enter Weekly Salary");
                        WeeklySalary = Convert.ToDecimal(Console.ReadLine());
                        SE = new SalariedEmployee(FirstName, LastName, SSN, WeeklySalary);
                        Info.Add(SE);
                        Console.WriteLine("Information Added. Press any Key to return.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (keyInfo.Key == ConsoleKey.NumPad2 || keyInfo.Key == ConsoleKey.D2)
                    {
                        Console.WriteLine("Enter First Name");
                        FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        LastName = Console.ReadLine();
                        Console.WriteLine("Enter SSN");
                        SSN = Console.ReadLine();
                        Console.WriteLine("Enter Hourly Wage");
                        HourlyWage = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter Weekly Hours Worked");
                        HoursWorked = Convert.ToInt32(Console.ReadLine());
                        HE = new HourlyEmployee(FirstName, LastName, SSN, HourlyWage, HoursWorked);
                        Info.Add(HE);
                        Console.WriteLine("Information Added. Press any Key to return.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (keyInfo.Key == ConsoleKey.NumPad2 || keyInfo.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Enter 4-digit part number");
                    PartNumber = Console.ReadLine();
                    Console.WriteLine("Enter Part Description");
                    PartDescription = Console.ReadLine();
                    Console.WriteLine("Enter Amount");
                    Quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Price");
                    Price = Convert.ToDecimal(Console.ReadLine());
                    IE = new Invoice(random.Next(99999, 1000000)+"_" +PartNumber, Quantity, PartDescription, Price);
                    Info.Add(IE);
                    Console.WriteLine("Information Added. Press any Key to return.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(keyInfo.Key == ConsoleKey.NumPad3 || keyInfo.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("Weekly Cash Flow Analysis is as follows:");
                    Console.WriteLine("");
                    Console.WriteLine(Info.Salary());
                    Console.WriteLine(Info.Hourly());
                    Console.WriteLine(Info.Invoice());
                    Console.WriteLine("Total Weekly Payout: " + Info.TotalWeeklyPayout());
                    Console.WriteLine("Category Breakdown:");
                    Console.WriteLine("Invoices: " + Info.InvoicePayout());
                    Console.WriteLine("Salaried Payroll: " + Info.SalaryPayout());
                    Console.WriteLine("Hourly Payroll: " + Info.HourlyPayout());
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to return to menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(keyInfo.Key == ConsoleKey.NumPad4 || keyInfo.Key == ConsoleKey.D4)
                {
                    Escape = true;
                }
            } while (Escape != true);
        }
    }
}
