﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Area51NyeSikkerhedssysyem
{
    public class Panel
    {
        
        public int ID { get; set; }

        public static void ElevatorRecrest(int person, Program database)
        {
            Kontrol.AddDistanceToOrderlist(person, database);
        }
    }
}
