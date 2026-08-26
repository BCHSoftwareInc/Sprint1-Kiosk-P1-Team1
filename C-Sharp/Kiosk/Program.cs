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
            Console.WriteLine("Enter Email:");

            string email = Console.ReadLine();

            Console.WriteLine("========================================");
            Console.WriteLine("      BCH ENTERPRISE VISITOR KIOSK      ");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine("========================================");

            // SE: Use Console.ReadLine() to capture 4 data fields
            // SE: Use Console.WriteLine() to render the ASCII badge
        }
    }
}