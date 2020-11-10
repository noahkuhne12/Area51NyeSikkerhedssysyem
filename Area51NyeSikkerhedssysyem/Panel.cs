using System;
using System.Collections.Generic;
using System.Text;

namespace Area51NyeSikkerhedssysyem
{
    public class Panel
    {
        
        public int ID { get; set; }

        public Kontrol MyController;
        public Staff MyStaff;

        public Panel(Kontrol ctlr, Staff staff)
        {
            MyController = ctlr;
            MyStaff = staff;
        }

        public static void ElevatorRecrest()
        {

        }
    }
}
