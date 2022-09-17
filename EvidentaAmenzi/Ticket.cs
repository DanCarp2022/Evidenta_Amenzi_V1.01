using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace EvidentaAmenzi
{
    [Serializable]
    internal class Ticket
    {
        private uint _issuerID;
        public uint IssuerID
        {
            get { return _issuerID; }
            set { _issuerID = value; }
        }

        private string _driversName;
        public string DriversName
        {
            get { return _driversName; }
            set { _driversName = value; }
        }

        private string _driversSurname;
        public string DriverSurname
        {
            get { return _driversSurname; }
            set { _driversSurname = value; }
        }

        private string _vehicleCathegory;
        public string VehicleCathegory
        {
            get { return _vehicleCathegory; }
            set { _vehicleCathegory = value; }
        }

        private uint _fineValue;
        public uint FineValue
        {
            get { return _fineValue; }
            set { _fineValue = value; }
        }

    }
}
