using System;
using System.Collections.Generic;

namespace Area51NyeSikkerhedssysyem
{
    public class Program
    {
        public List<Flor> FlorList { get; set; }
        public List<Staff> StaffList { get; set; }
        static void Main(string[] args)
        {
            Program program = new Program
            {
                FlorList = new List<Flor>(),
                StaffList = new List<Staff>()
            };

            Kontrol kontrol = new Kontrol();
            Elevator elevator = new Elevator();

            Console.WriteLine("enter how many staff i nidet");
            int howManyStaff = Convert.ToInt32(Console.ReadLine());

            Staff.CreateStaff(howManyStaff, program);

            //Staff test

            foreach (Staff staff in program.StaffList)
            {
                Console.WriteLine(staff.ID);
                Console.WriteLine(staff.SecurityCertificates);
                Console.WriteLine(staff.SpawnFlor);
                Console.WriteLine(staff.TagetFlor);
                Console.WriteLine(staff.SpawnTime);
                Console.WriteLine(staff.DieState);
            }
            Console.ReadLine();

            Flor flor = new Flor(kontrol, program);

            //Flor test

            //foreach (Flor flor in program.FlorList)
            //{
            //    Console.WriteLine(flor.FlorNumber);
            //    Console.WriteLine(flor.SecurityLevel);
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            
            int timer = 0;

            while (timer != 100)
            {
                for (int i = 0; i < program.StaffList.Count; i++)
                {
                    if (timer == program.StaffList[i].SpawnTime)
                    {
                        int flor = program.StaffList[i].SpawnFlor;

                        Panel.ElevatorRecrest(flor);
                    }
                }
                timer++;
            }
        }
    }
}
