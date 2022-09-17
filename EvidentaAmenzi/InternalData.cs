using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaAmenzi
{
    internal static class InternalData
    {
        public static string fileName = "PoliceData.save";
        public static Agent virtualAgent = new Agent() { Name = "Agent", Surname = "Virtual", AgentID = 8 };
        public static List<Agent> agents = new List<Agent>();
        public static List<Ticket> tickets = new List<Ticket>();
        public static List<Agent> retiredAgents = new List<Agent>();
        public static List<uint> agentIDs = new List<uint>();

    }
}
