using System;
using System.Collections.Generic;
using System.Text;

namespace Area51NyeSikkerhedssysyem
{
    public class Staff
    {
        public int ID { get; set; }
        public int SecurityCertificates { get; set; }
        public int SpawnFlor { get; set; }
        public int TagetFlor { get; set; }
        public int SpawnTime { get; set; }
        public bool DieState { get; set; }

        public static void CreateStaff(int numberForStaff, Program database)
        {
            

            for (int i = 0; i < numberForStaff; i++)
            {
                database.StaffList.Add(new Staff());
                database.StaffList[i].ID = i;
                database.StaffList[i].SecurityCertificates = Random(0, 5);
                database.StaffList[i].SpawnFlor = Random(0, 3);
                database.StaffList[i].TagetFlor = Random(0, 3);
                database.StaffList[i].SpawnTime = Random(0, 100);
                database.StaffList[i].DieState = false;
            }
        }
        private static int Random(int num1, int num2)
        {
            int random_number = new Random().Next(num1, num2);

            return random_number;
        }
    }
}
