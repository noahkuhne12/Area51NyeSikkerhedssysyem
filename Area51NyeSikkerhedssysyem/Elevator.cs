using System;
using System.Collections.Generic;
using System.Text;

namespace Area51NyeSikkerhedssysyem
{
    class Elevator
    {
        public List<int> Orderlist { get; set; }

        private int StartFlor 
        {
            get { return StartFlor; } 
            set { StartFlor = 0; } 
        }
        public int Capacity 
        {
            get { return Capacity; } 
            set { Capacity = 1; } 
        }
    }
}
