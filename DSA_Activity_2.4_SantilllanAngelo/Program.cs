using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Activity_2._4_SantilllanAngelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> jobs = new Queue<string>();

            Console.WriteLine("Welcome to my JOB SCHEDULING");
            int choice = 0;
            do 
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Job Name: ");
                        string newJob = Console.ReadLine();
                        jobs.Enqueue(newJob);
                        Console.WriteLine($"Job '{newJob}' added to the queue.");
                        break;


                }


                if (choice != 7)
                {
                    DisplayMenu();
                }
            }while (choice != 7);

        }
        static void DisplayMenu()
        {
            Console.WriteLine("Choose what you want to do?");
            Console.WriteLine("1. New Job");
            Console.WriteLine("2. Finish Job");
            Console.WriteLine("3. Search Job");
            Console.WriteLine("4. Current Job");
            Console.WriteLine("5. Display All Jobs");
            Console.WriteLine("6. Count Job");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
        }
    }
}
