using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSChkLst
{
    class Aircraft
    {
        private int aircraftID;
        private string aircraftDescription;

        public int AircraftID
        {
            get => aircraftID;
            set => aircraftID = value;
        }

        public string AircraftDescription
        {
            get => aircraftDescription;
            set => aircraftDescription = value;
        }
    }
}
