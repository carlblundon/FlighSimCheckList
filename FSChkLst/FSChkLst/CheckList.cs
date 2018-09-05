using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSChkLst
{
    class CheckList
    {
        private int checkListID;
        private int aircraftID;
        private string checkListDescription;

        public int CheckListID
        {
            get => checkListID;
            set => checkListID = value;
        }

        public int AircraftID
        {
            get => aircraftID;
            set => aircraftID = value;
        }

        public string CheckListDescription
        {
            get => checkListDescription;
            set => checkListDescription = value;
        }
    }
}
