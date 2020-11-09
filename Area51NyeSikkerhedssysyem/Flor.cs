using System;
using System.Collections.Generic;
using System.Text;

namespace Area51NyeSikkerhedssysyem
{
    public class Flor
    {
        public int FlorNumber { get; set; }
        public int SecurityLevel { get; set; }

        Scanner Myscanner = new Scanner();
        Panel MyPanel = new Panel();
        CeilingTruret MyCeilingTruret = new CeilingTruret();
        public Flor(Kontrol ctrl, int i)
        {
            Myscanner.kontrol = ctrl; 
            
            FlorNumber = i;
            SecurityLevel = i + 1;
            Myscanner.ID = i;
            MyPanel.ID = i;
            MyCeilingTruret.ID = i;

        }
        
    }
}
