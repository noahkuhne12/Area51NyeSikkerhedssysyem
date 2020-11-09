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

        int count = 0;
        public Staff()
        {
            ID = count;
            SecurityCertificates = Random(0, 5);
            SpawnFlor = Random(0, 3);
            TagetFlor = Random(0, 3);
            SpawnTime = Random(0, 100);
            DieState = false;
            count++;
        }

        private static int Random(int num1, int num2)
        {
            int random_number = new Random().Next(num1, num2);

            return random_number;
        }
    }
}
