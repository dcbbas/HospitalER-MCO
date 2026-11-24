using System;

namespace HospitalERManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DAY 1: CUSTOM SET ADT TEST ===");

            CustomSet<string> patientAllergies = new CustomSet<string>();
            patientAllergies.Add("Penicillin");
            patientAllergies.Add("Peanuts");
            patientAllergies.Add("Penicillin"); // Duplicate test

            Console.WriteLine("\nPatient Allergies Set:");
            patientAllergies.Display();

            CustomSet<string> restrictedMeds = new CustomSet<string>();
            restrictedMeds.Add("Penicillin");
            restrictedMeds.Add("Aspirin");

            Console.WriteLine("\nRestricted Medications Set:");
            restrictedMeds.Display();

            Console.WriteLine("\n--- Set Operations ---");
            Console.WriteLine("Union (Allergies U Restricted):");
            patientAllergies.Union(restrictedMeds).Display();

            Console.WriteLine("\nIntersection (Common items):");
            patientAllergies.Intersection(restrictedMeds).Display();

            Console.WriteLine("\nDifference (Allergies - Restricted):");
            patientAllergies.Difference(restrictedMeds).Display();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}