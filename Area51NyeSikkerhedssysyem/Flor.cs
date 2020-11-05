using System;
using System.Collections.Generic;
using System.Text;

namespace Area51NyeSikkerhedssysyem
{
    public class Flor
    {
        public int FlorNumber { get; set; }
        public int SecurityLevel { get; set; }

        public static void CreateFlor(Database _database)
        {
            int flors = 4;

            Database database = _database;
            
            for (int i = 0; i < flors; i++)
            {
                database.FlorList.Add(new Flor());
                database.FlorList[i].FlorNumber = i;
                database.FlorList[i].SecurityLevel = i + 1;
            }
        }
    }
}
