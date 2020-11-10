using System;
using System.Collections.Generic;
using System.Text;

namespace Area51NyeSikkerhedssysyem
{
    public class Flor
    {
        public int FlorNumber { get; set; }
        public int SecurityLevel { get; set; }
        public List<Staff> StaffOnFlor { get; set; }

        Scanner Myscanner;
        Panel MyPanel;
        CeilingTruret MyCeilingTruret;
        public Flor(Kontrol ctlr, Staff staff, int numberOfFlors)
        {
            Myscanner = new Scanner(ctlr);
            MyPanel = new Panel(ctlr, staff);
            MyCeilingTruret = new CeilingTruret(ctlr);

            FlorNumber = numberOfFlors;
            SecurityLevel = numberOfFlors + 1;
            Myscanner.ID = numberOfFlors;
            MyPanel.ID = numberOfFlors;
            MyCeilingTruret.ID = numberOfFlors;
        }

    }
}
