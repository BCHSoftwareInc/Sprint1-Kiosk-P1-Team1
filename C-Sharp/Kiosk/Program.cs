// BCH Software Inc. - Sprint 1: Interactive Kiosk
// Track: C# / CIS151 Software Engineering
using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace BCHSoftware
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Enter Full Name:");
            Console.WriteLine("========================================");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("Enter Email:");
            Console.WriteLine("========================================");
            string email = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("Enter Organization:");
            Console.WriteLine("========================================");
            string org = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("Enter Acess Level:");
            Console.WriteLine("========================================");
            string access = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("      BCH ENTERPRISE VISITOR KIOSK      ");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Organization: {org}");
            Console.WriteLine($"Access: {access}");
            Console.WriteLine("========================================");

            // SE: Use Console.ReadLine() to capture 4 data fields
            // SE: Use Console.WriteLine() to render the ASCII badge
        }
    }
}