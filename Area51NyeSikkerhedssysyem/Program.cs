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
            int howManyStaff = Convert.ToInt32(Console.ReadLine());

            Staff.CreateStaff(howManyStaff, database);

        }
    }
}
