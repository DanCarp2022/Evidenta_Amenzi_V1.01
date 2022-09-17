using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaAmenzi
{
    [Serializable]
    internal class BoxedData
    {
        private List<Agent> agents = new List<Agent>();
        private List<Ticket> tickets = new List<Ticket>();
        private List<Agent> retiredAgents = new List<Agent>();


        public List<Agent> Agents { get { return agents; } set { agents = value; } }
        public List<Ticket> Tickets { get { return tickets; } set { tickets = value; } }
        public List<Agent> RetiredAgents { get { return retiredAgents; } set { retiredAgents = value; } }

        public BoxedData()
        { 
            agents = InternalData.agents;
            tickets = InternalData.tickets;
            retiredAgents = InternalData.retiredAgents;
        }

    }
}
