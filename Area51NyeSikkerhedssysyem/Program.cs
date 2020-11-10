using System;
using System.Collections.Generic;

namespace Area51NyeSikkerhedssysyem
{
    public class Program
    {
        int numberOfFlors;
        int numberOfStaff;
        Elevator elevator;
        Kontrol kontrol;
        Flor flor;
        Staff staff;
        public Program()
        {
            elevator = new Elevator();
            kontrol = new Kontrol();
            flor = new Flor(kontrol, staff, numberOfFlors);
            staff = new Staff(numberOfStaff);
            
        }
        public List<Flor> FlorList { get; set; }
        public List<Staff> StaffList { get; set; }
        static void Main(string[] args)
        {
            Program database = new Program
            {
                FlorList = new List<Flor>(),
                StaffList = new List<Staff>()
            };

 
        

            Console.WriteLine("number Of Staff");
            int howManyStaff = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < howManyStaff; i++)
            {
                database.numberOfStaff = i;
                Staff staff = new Staff(database.numberOfStaff);
                database.StaffList.Add(staff);
            }


            //Staff test

            foreach (Staff staf in database.StaffList)
            {
                Console.WriteLine(staf.ID);
                Console.WriteLine(staf.SecurityCertificates);
                Console.WriteLine(staf.SpawnFlor);
                Console.WriteLine(staf.TagetFlor);
                Console.WriteLine(staf.SpawnTime);
                Console.WriteLine(staf.DieState);
            }
            Console.ReadLine();

            int flors = 4;

            //for (int i = 0; i < flors; i++)
            //{
            //    Flor flor = new Flor(kontrol, i);
            //    database.FlorList.Add(flor);
            //}
            for (int i = 0; i < flors; i++)
            {
                database.numberOfFlors = i;
                Flor flor = new Flor(database.kontrol, database.staff, database.numberOfFlors);
                database.FlorList.Add(flor);
            }


            //Flor test

            foreach (Flor florr in database.FlorList)
            {
                Console.WriteLine(florr.FlorNumber);
                Console.WriteLine(florr.SecurityLevel);
                Console.WriteLine();
            }
            Console.ReadLine();

            int timer = 0;

            while (timer != 100)
            {
                for (int i = 0; i < database.StaffList.Count; i++)
                {
                    if (timer == database.StaffList[i].SpawnTime)
                    {
                        database.flor.StaffOnFlor.Add(database.StaffList[i]);

                        Panel.ElevatorRecrest();
                    }
                }
                timer++;
            }
        }
    }
}
