using System;
using HospitalERManagementSystem.ADTs;
using HospitalERManagementSystem.Models;

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

            Console.WriteLine("\n=== DAY 2: CUSTOM QUEUE ADT TEST ===");

            CustomQueue<Patient> erQueue = new CustomQueue<Patient>();
            erQueue.Enqueue(new Patient("P001", "Ana Reyes", 28, "Fever", 3));
            erQueue.Enqueue(new Patient("P002", "Carlo Santos", 45, "Sprain", 4));

            Console.WriteLine("\nCurrent ER Queue:");
            erQueue.Display();

            Console.WriteLine("\nNext patient (Peek):");
            Console.WriteLine(erQueue.Peek());

            Console.WriteLine("\nDequeued patient:");
            Console.WriteLine(erQueue.Dequeue());

            Console.WriteLine($"\nRemaining in queue: {erQueue.Count} (IsEmpty: {erQueue.IsEmpty()})");
            erQueue.Display();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}