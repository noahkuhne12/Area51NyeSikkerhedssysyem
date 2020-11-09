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
            Program database = new Program
            {
                FlorList = new List<Flor>(),
                StaffList = new List<Staff>()
            };

            Kontrol kontrol = new Kontrol();
            Elevator elevator = new Elevator();



        

            Console.WriteLine("number Of Staff");
            int numberOfStaff = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfStaff; i++)
            {
                Staff staff = new Staff(i);
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

            for (int i = 0; i < flors; i++)
            {
                Flor flor = new Flor(kontrol, i);
                database.FlorList.Add(flor);
            }
            

            //Flor test

            //foreach (Flor flor in program.FlorList)
            //{
            //    Console.WriteLine(flor.FlorNumber);
            //    Console.WriteLine(flor.SecurityLevel);
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            
            //int timer = 0;

            //while (timer != 100)
            //{
            //    for (int i = 0; i < database.StaffList.Count; i++)
            //    {
            //        if (timer == database.StaffList[i].SpawnTime)
            //        {
            //            int flor = database.StaffList[i].SpawnFlor;

            //            Panel.ElevatorRecrest(flor);
            //        }
            //    }
            //    timer++;
            //}
        }
    }
}
