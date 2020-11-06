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

        public static void CreateFlor(Program program)
        {
            int flors = 4;

            Program database = program;
            
            for (int i = 0; i < flors; i++)
            {
                database.FlorList.Add(new Flor());
                database.FlorList[i].FlorNumber = i;
                database.FlorList[i].SecurityLevel = i + 1;
                database.FlorList[i].Myscanner.ID = i;
                database.FlorList[i].MyPanel.ID = i;
                database.FlorList[i].MyCeilingTruret.ID = i;
            }
        }
    }
}
