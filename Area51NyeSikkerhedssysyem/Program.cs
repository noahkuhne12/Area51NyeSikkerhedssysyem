using System;
using System.Collections.Generic;

namespace Area51NyeSikkerhedssysyem
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            Elevator elevator = new Elevator();
            database.StaffList = new List<Staff>();
            

            Console.WriteLine("enter how many staff i nidet");
            int howManyStaff =Convert.ToInt32(Console.ReadLine());

            Staff.CreateStaff(howManyStaff, database);

            //Staff test

            foreach (Staff staff in database.StaffList)
            {
                Console.WriteLine(staff.ID);
                Console.WriteLine(staff.SecurityCertificates);
                Console.WriteLine(staff.SpawnFlor);
                Console.WriteLine(staff.TagetFlor);
                Console.WriteLine(staff.SpawnTime);
                Console.WriteLine(staff.DieState);
            }
            Console.ReadLine();

            database.FlorList = new List<Flor>();
            Flor.CreateFlor(database);

            //Flor test

            foreach (Flor flor in database.FlorList)
            {
                Console.WriteLine(flor.FlorNumber);
            }
            Console.ReadLine();


        }
    }
}
