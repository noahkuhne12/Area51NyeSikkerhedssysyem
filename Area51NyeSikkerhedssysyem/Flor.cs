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

        int count = 0;
        public Flor()
        {
            Myscanner.kontrol = ctrl; 
            
            FlorNumber = count;
            SecurityLevel = count + 1;
            Myscanner.ID = count;
            MyPanel.ID = count;
            MyCeilingTruret.ID = count;
            count++;
        }
        
    }
}
