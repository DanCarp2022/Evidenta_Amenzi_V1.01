using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace EvidentaAmenzi
{
    [Serializable]
    internal class Agent
    {
        private string _name;
        public string Name
        {
            get{ return _name;}
            set{ _name = value; }
        }

        private string _surname;
        public string Surname
        {
            get{ return _surname;}
            set{ _surname = value; }
        }

        private uint _agentID;
        public uint AgentID
        {
            get { return _agentID; }
            set { _agentID = value; }
        }

        private uint _totalAmound;
        public uint TotalAmound 
        {
            get { return _totalAmound; } 
            set { _totalAmound = value; }
        }
    }
}
