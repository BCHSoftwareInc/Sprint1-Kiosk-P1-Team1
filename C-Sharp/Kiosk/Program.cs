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
            const int insideWidth = 36;

            const int maxInputLength = 22;

            string Cap(string input) => input.Length > maxInputLength ? input[..maxInputLength] : input;

            Console.WriteLine("========================================");
            Console.WriteLine("Enter Full Name:");
            string name = Console.ReadLine();
            Console.WriteLine("========================================");
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Console.WriteLine("========================================");
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("Enter Organization:");
            string org = Console.ReadLine();
            Console.WriteLine("========================================");
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("Enter Access Level:");
            string access = Console.ReadLine();
            Console.WriteLine("========================================");
            Console.Clear();
            Console.WriteLine("+======================================+");
            Console.WriteLine("|      Apex Entertainment Pass         |");
            Console.WriteLine($"| {$"Name: {Cap(name)}".PadRight(insideWidth)} |");
            Console.WriteLine($"| {$"Email: {Cap(email)}".PadRight(insideWidth)} |");
            Console.WriteLine($"| {$"Organization: {Cap(org)}".PadRight(insideWidth)} |");
            Console.WriteLine($"| {$"Access: {Cap(access)}".PadRight(insideWidth)} |");
            Console.WriteLine("+======================================+");
            // SE: Use Console.ReadLine() to capture 4 data fields
            // SE: Use Console.WriteLine() to render the ASCII badge
        }
    }
}