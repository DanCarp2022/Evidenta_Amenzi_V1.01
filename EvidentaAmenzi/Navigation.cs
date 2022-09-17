using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaAmenzi
{
    internal static class Navigation
    {

        ///////////// Menues /////////////
        public static void OnStartActions()
        {
            BoxedData data = SaveSystem.LoadData(InternalData.fileName);
            InternalData.agents.AddRange(data.Agents);
            InternalData.tickets.AddRange(data.Tickets);
            InternalData.retiredAgents.AddRange(data.RetiredAgents);
            InternalData.agentIDs.Add(InternalData.virtualAgent.AgentID);
            foreach (Agent agent in InternalData.agents)
            {
                InternalData.agentIDs.Add(agent.AgentID);
            }
        }
        public static void Menu_MainMenu()
        {
            Console.Clear();
            Console.WriteLine("<<< MENIU PRINCIPAL >>> \r\n");
            Console.WriteLine("Alegeti operatiunea dorita: \r\n");
            Console.WriteLine("(Introdu un numar de la 1 la 7) \r\n");

            Console.WriteLine();

            Console.WriteLine("[1] Adauga agent");
            Console.WriteLine("[2] Sterge agent");
            Console.WriteLine("[3] Adauga amenda");
            Console.WriteLine("[4] Afiseaza amenzi agent");
            Console.WriteLine("[5] Afiseaza amenzi contravenient");
            Console.WriteLine("[6] Afiseaza situatie amenzi");
            Console.WriteLine("[7] Iesire");

            Console.WriteLine();


            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length != 0)
            {
                if (input.Length == 1)
                {

                    char symbol = input[0];
                    int i = symbol - '0';
                    Console.WriteLine(symbol + "<<<<");

                    switch (i)
                    {
                        case 1:
                            Menu_AddAnAgent();
                            break;

                        case 2:
                            Menu_RemoveAnAgent();
                            break;

                        case 3:
                            Menu_AddATicket();
                            break;

                        case 4:
                            Menu_TicketOverview_byAgent();
                            break;

                        case 5:
                            Menu_TicketOverview_byDriver();
                            break;

                        case 6:
                            Menu_TicketOvervie_byState();
                            break;

                        case 7:
                            Console.Clear();
                            Console.WriteLine("Ati ales optiunea 7");
                            SaveSystem.SaveData(InternalData.fileName);
                            Console.WriteLine("O zi buna!");
                            CloseTheProgram();
                            break;

                        default:
                            Console.WriteLine("Input incorect");
                            Console.ReadKey(true);
                            Menu_MainMenu();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ati introdus mai multe caractere");
                    Console.ReadKey(true);
                    Menu_MainMenu();
                }

            }
            else
            {
                Console.WriteLine("Nu a fost aleasa nicio optiune");
                Console.ReadKey(true);
                Menu_MainMenu();
            }
        }
        public static void Menu_AddAnAgent()
        {
            Console.Clear();
            Console.WriteLine("<<< MENIU ADAUGARE AGENT >>> \r\n");
            Console.WriteLine("Alegeti operatiunea dorita: \r\n");
            //Console.WriteLine("(Introdu un numar de la 1 la 7) \r\n");

            Console.WriteLine("[1] Adauga agent");
            Console.WriteLine("[2] Revenire la Meniul Principal");

            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length != 0)
            {
                if (input.Length == 1)
                {

                    char symbol = input[0];
                    int i = symbol - '0';

                    switch (i)
                    {
                        case 1:
                            AddAnAgent();
                            break;

                        case 2:
                            Menu_MainMenu();
                            break;

                        default:
                            Console.WriteLine("\r\n<!> Input incorect");
                            Console.ReadKey(true);
                            Menu_AddAnAgent();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\r\n<!> Ati introdus mai multe caractere");
                    Console.ReadKey(true);
                    Menu_AddAnAgent();
                }

            }
            else
            {
                Console.WriteLine("\r\n<!> Nu a fost aleasa nicio optiune");
                Console.ReadKey(true);
                Menu_AddAnAgent();
            }
        }
        public static void Menu_RemoveAnAgent()
        {
            Console.Clear();
            Console.WriteLine("<<< MENIU STERGE AGENT >>>");
            PrintAllAgents();
            PrintRetiredAgents();

            Console.WriteLine("Alegeti operatiunea dorita: \r\n");
            Console.WriteLine("[1] Sterge agent");
            Console.WriteLine("[2] Revenire la Meniul Principal");

            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length != 0)
            {
                if (input.Length == 1)
                {

                    char symbol = input[0];
                    int i = symbol - '0';
                    Console.WriteLine(symbol + "<<<<");

                    switch (i)
                    {
                        case 1:
                            RemoveAnAgent();
                            break;

                        case 2:
                            Menu_MainMenu();
                            break;

                        default:
                            Console.WriteLine("\r\n<!> Input incorect");
                            Console.ReadKey(true);
                            Menu_RemoveAnAgent();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\r\n<!> Ati introdus mai multe caractere");
                    Console.ReadKey(true);
                    Menu_RemoveAnAgent();
                }

            }
            else
            {
                Console.WriteLine("\r\n<!> Nu a fost aleasa nicio optiune");
                Console.ReadKey(true);
                Menu_RemoveAnAgent();
            }
        }
        public static void Menu_AddATicket()
        {
            Console.Clear();
            Console.WriteLine("<<< MENIU ADAUGARE AMENDA >>> \r\n");
            Console.WriteLine("Alegeti operatiunea dorita: \r\n");

            Console.WriteLine("[1] Adauga o amenda");
            Console.WriteLine("[2] Revenire la Meniul Principal");

            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length != 0)
            {
                if (input.Length == 1)
                {

                    char symbol = input[0];
                    int i = symbol - '0';
                    Console.WriteLine(symbol + "<<<<");

                    switch (i)
                    {
                        case 1:
                            AddTicket();
                            break;

                        case 2:
                            Menu_MainMenu();
                            break;

                        default:
                            Console.WriteLine("\r\n<!> Input incorect");
                            Console.ReadKey(true);
                            Menu_AddATicket();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\r\n<!> Ati introdus mai multe caractere");
                    Console.ReadKey(true);
                    Menu_AddATicket();
                }

            }
            else
            {
                Console.WriteLine("\r\n<!> Nu a fost aleasa nicio optiune");
                Console.ReadKey(true);
                Menu_AddATicket();
            }
        }
        public static void Menu_TicketOverview_byAgent()
        {
            Console.Clear();
            Console.WriteLine("<<< MENIU DE AFISARE - AMENZI AGENT >>> \r\n");
            Console.WriteLine("Alegeti operatiunea dorita: \r\n");
            //Console.WriteLine("(Introdu un numar de la 1 la 7) \r\n");

            Console.WriteLine("1. Afiseaza amenzile agentilor");
            Console.WriteLine("2. Afiseaza toate amenzile");
            Console.WriteLine("3. Revenire la Meniul Principal");

            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length != 0)
            {
                if (input.Length == 1)
                {

                    char symbol = input[0];
                    int i = symbol - '0';
                    Console.WriteLine(symbol + "<<<<");

                    switch (i)
                    {
                        case 1:
                            ListTicketsByAgent();
                            break;

                        case 2:
                            PrintAllTheTickets(InternalData.tickets);
                            Menu_TicketOverview_byAgent();
                            break;

                        case 3:
                            Menu_MainMenu();
                            break;

                        default:
                            Console.WriteLine("Input incorect");
                            Console.ReadKey(true);
                            Menu_TicketOverview_byAgent();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ati introdus mai multe caractere");
                    Console.ReadKey(true);
                    Menu_TicketOverview_byAgent();
                }

            }
            else
            {
                Console.WriteLine("Nu a fost aleasa nicio optiune");
                Console.ReadKey(true);
                Menu_TicketOverview_byAgent();
            }
        }
        public static void Menu_TicketOverview_byDriver()
        {
            Console.Clear();
            Console.WriteLine("<<< MENIU DE AFISARE - AMENZI CONTRAVENIENT >>> \r\n");
            Console.WriteLine("Alegeti operatiunea dorita: \r\n");
            //Console.WriteLine("(Introdu un numar de la 1 la 7) \r\n");

            Console.WriteLine("1. Afiseaza contravenientii");
            Console.WriteLine("2. Revenire la Meniul Principal");

            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length != 0)
            {
                if (input.Length == 1)
                {

                    char symbol = input[0];
                    int i = symbol - '0';
                    Console.WriteLine(symbol + "<<<<");

                    switch (i)
                    {
                        case 1:
                            ListTicketstByDriver();
                            break;

                        case 2:
                            Menu_MainMenu();
                            break;

                        default:
                            Console.WriteLine("Input incorect");
                            Console.ReadKey(true);
                            Menu_TicketOverview_byDriver();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ati introdus mai multe caractere");
                    Console.ReadKey(true);
                    Menu_TicketOverview_byDriver();
                }

            }
            else
            {
                Console.WriteLine("Nu a fost aleasa nicio optiune");
                Console.ReadKey(true);
                Menu_TicketOverview_byDriver();
            }
        }
        public static void Menu_TicketOvervie_byState()
        {
            Console.Clear();
            Console.WriteLine("<<< MENIU DE AFISARE - SITUATIE AMENZI >>> \r\n");
            Console.WriteLine("Alegeti operatiunea dorita: \r\n");
            //Console.WriteLine("(Introdu un numar de la 1 la 7) \r\n");

            Console.WriteLine("1. Afiseaza situatie amenzi");
            Console.WriteLine("2. Revenire la Meniul Principal");

            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length != 0)
            {
                if (input.Length == 1)
                {

                    char symbol = input[0];
                    int i = symbol - '0';
                    Console.WriteLine(symbol + "<<<<");

                    switch (i)
                    {
                        case 1:
                            ListAllTicketsByValue();
                            break;

                        case 2:
                            Menu_MainMenu();
                            break;

                        default:
                            Console.WriteLine("Input incorect");
                            Console.ReadKey(true);
                            Menu_AddAnAgent();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ati introdus mai multe caractere");
                    Console.ReadKey(true);
                    Menu_AddAnAgent();
                }

            }
            else
            {
                Console.WriteLine("Nu a fost aleasa nicio optiune");
                Console.ReadKey(true);
                Menu_AddAnAgent();
            }
        }

        ///////////// In menu actions /////////////
        public static void AddAnAgent() {

            Console.WriteLine("]> Introduceti numele agentului:");
            string numeAgent = Console.ReadLine();
            char[] cNumeAgent = numeAgent.ToCharArray();

            if (CheckIfLetters(cNumeAgent))
            {
                Console.WriteLine("\r\nNume agent: " + numeAgent);
                Console.WriteLine("==============================================================");
                //Console.ReadKey();
            }
            else
            {
                while (CheckIfLetters(cNumeAgent) == false)
                {
                    Console.WriteLine("Ati introdus => {0}", numeAgent);
                    Console.WriteLine("\r\n<!> Numele introdus nu este valid. Excludeti utilizarea spatiilor, a cifrelor sau a simbolurilor.");
                    Console.WriteLine("\r\nIncercati din nou...");
                    Console.ReadKey();
                    Console.WriteLine("]> Introduceti Numele agentului:");
                    numeAgent = Console.ReadLine();
                    cNumeAgent = numeAgent.ToCharArray();
                }
                Console.WriteLine("\r\nNume agent: " + numeAgent);
                Console.WriteLine("==============================================================");
                //Console.ReadKey();
            }

            Console.WriteLine("\r\n]> Introduceti Prenumele agentului");
            string prenumeAgent = Console.ReadLine();
            char[] cPrenumeAgent = prenumeAgent.ToCharArray();

            if (CheckIfLetters(cPrenumeAgent))
            {
                Console.WriteLine("\r\nPrenume agent: " + prenumeAgent);
                Console.WriteLine("==============================================================");
                //Console.ReadKey();
            }
            else
            {
                while (CheckIfLetters(cPrenumeAgent) == false)
                {
                    Console.WriteLine("Ati introdus => {0}", prenumeAgent);
                    Console.WriteLine("\r\n<!> Prenumele introdus nu este valid. Excludeti utilizarea spatiilor, a cifrelor sau a simbolurilor.");
                    Console.WriteLine("\r\nIncercati din nou...");
                    Console.ReadKey();
                    Console.WriteLine("]> Introduceti Prenumele agentului:");
                    prenumeAgent = Console.ReadLine();
                    cPrenumeAgent = prenumeAgent.ToCharArray();
                }

                Console.WriteLine("\r\nPrenume agent: " + prenumeAgent);
                Console.WriteLine("==============================================================");
                //Console.ReadKey();
            }

            ///////////////////////// ID Generation /////////////////////////

            Random random = new Random();
            uint idAgent = (uint)random.Next(1000, 10000);
            if (InternalData.agentIDs.Contains(idAgent))
            {
                while (InternalData.agentIDs.Contains(idAgent))
                {
                    idAgent = (uint)random.Next(1000, 10000);
                }
            }
            Console.WriteLine("\r\n <[ Agentul >> {0} {1} << a primit ID-ul: {2} ]>", numeAgent, prenumeAgent, idAgent);

            Console.WriteLine("\r\n]> Doriti sa adaugati agentul in lista cu agenti ? \r\n     >>>>>>> DA: 1 / NU: 2 <<<<<<<");

            char[] input = Console.ReadLine().ToCharArray();
            bool chosedOption = Yes_No_navigation(input);

            if (chosedOption)
            {
                Agent newAgent = new Agent() { Name = numeAgent, Surname = prenumeAgent, AgentID = idAgent };
                InternalData.agents.Add(newAgent);
                InternalData.agentIDs.Add(idAgent);
                Console.WriteLine("Agentul: \r\n{0} {1}   ID: {2} - A fost adaugat in lista cu agenti.", newAgent.Name, newAgent.Surname, newAgent.AgentID);
                Console.WriteLine("==============================================================");
                Console.ReadKey();
                Menu_AddAnAgent();
            }
            else
            {
                Console.WriteLine("\r\n]> Doriti sa anulati operatiunea de adaugare agent ? \r\n     >>>>>>> DA: 1 / NU: 2 <<<<<<<");
                char[] input_2 = Console.ReadLine().ToCharArray();
                bool chosedOption_2 = Yes_No_navigation(input_2);
                if (chosedOption_2)
                {
                    Console.WriteLine("Veti fi redirectionati in meniul \"Adauga agent\"");
                    Console.ReadKey();
                    Menu_AddAnAgent();
                }
                else
                {
                    Console.WriteLine("\r\n]> Doriti sa adaugati agentul in lista cu agenti ? \r\n     >>>>>>> DA: 1 / NU: 2 <<<<<<<");
                    char[] input_3 = Console.ReadLine().ToCharArray();
                    bool chosedOption_3 = Yes_No_navigation(input_3);
                    if (chosedOption_3)
                    {
                        Agent newAgent = new Agent() { Name = numeAgent, Surname = prenumeAgent, AgentID = idAgent };
                        InternalData.agents.Add(newAgent);
                        InternalData.agentIDs.Add(idAgent);
                        Console.WriteLine("Agentul: \r\n{0} {1}   ID: {2} - A fost adaugat in lista cu agenti", newAgent.Name, newAgent.Surname, newAgent.AgentID);
                        Menu_AddAnAgent();
                    }
                    else
                    {
                        Console.WriteLine("\r\n<!> Sunteti cam indecisi astazi... Veti fi redirectionati in meniul anterior");
                        Console.ReadKey();
                        Menu_AddAnAgent();
                    }
                }
            }
        }
        public static void RemoveAnAgent()
        {
            Console.WriteLine("]> Selectati numarul agentului:");

            char[] cInputID = Console.ReadLine().ToCharArray();

            while (CheckIfNumber(cInputID) == false)
            {
                Console.WriteLine("Ati introdus => {0}", cInputID);
                Console.WriteLine("\r\n<!> Numarul introdus nu este valid. Introduceti doar numere. Excludeti utilizarea spatiilor, a literelor sau a simbolurilor.");
                Console.WriteLine("\r\nIncercati din nou...");
                Console.ReadKey();
                Console.WriteLine("]> Selectati numarul agentului:");
                char[] cInputID_2 = Console.ReadLine().ToCharArray();
                cInputID = cInputID_2;
            }

            string nString = new string(cInputID);
            uint inputID = Convert.ToUInt32(nString);


            if (InternalData.agents.Exists(x => x.AgentID == inputID)) //Does that ID exists ?
            {
                int indexOfAgent = InternalData.agents.FindIndex(x => x.AgentID == inputID);
                int indexOfID = InternalData.agentIDs.FindIndex(x => x == inputID);
                Agent selectedAgent = InternalData.agents[indexOfAgent];
                Console.WriteLine("\r\nAti selectat agentul: {0} {1}   ID: {2}", selectedAgent.Name, selectedAgent.Surname, selectedAgent.AgentID);

                Console.WriteLine("]> Doriti sa stergeti acest agent din lista de agenti ?");
                Console.WriteLine("\r\n >>>>>>> DA: 1 / NU: 2 <<<<<<< ");
                char[] inputAB_01 = Console.ReadLine().ToCharArray();

                if (Yes_No_navigation(inputAB_01)) //Yes - erase agent from the list
                {
                    Agent rAgent = new Agent() { Name = selectedAgent.Name, Surname = selectedAgent.Surname, AgentID = selectedAgent.AgentID };
                    InternalData.retiredAgents.Add(rAgent);
                    InternalData.agents.RemoveAt(indexOfAgent);
                    InternalData.agentIDs.RemoveAt(indexOfID);
                    foreach (Ticket t in InternalData.tickets)
                    {
                        if (t.IssuerID == inputID)
                        {
                            t.IssuerID = 8;
                        }
                    }

                    Console.WriteLine("==============================================================");
                    Console.WriteLine("\r\nAgentul a fost sters din sistem.");
                    Console.WriteLine("==============================================================");
                    Console.WriteLine("Veti fi redirectionati in meniul anterior");
                    Console.ReadKey();
                    Menu_RemoveAnAgent();
                }
                else //No - do not erase.
                {
                    Console.WriteLine("\r\n]> Doriti sa anulati operatiunea ?");
                    Console.WriteLine("[1] Da => Anulare si revenio la meniul anterior.");
                    Console.WriteLine("[2] Nu => Finalizare operatiune de stergere agent.");
                    char[] input = Console.ReadLine().ToCharArray();
                    bool chosedOption = Yes_No_navigation(input);

                    if (chosedOption)
                    {
                        Menu_RemoveAnAgent();
                    }
                    else
                    {
                        InternalData.retiredAgents.Add(selectedAgent);
                        InternalData.agents.RemoveAt(indexOfAgent);
                        foreach (Ticket t in InternalData.tickets)
                        {
                            if (t.IssuerID == inputID)
                            {
                                t.IssuerID = 8;
                            }
                        }

                        Console.WriteLine("==============================================================");
                        Console.WriteLine("\r\nAgentul a fost sters cu succes.");
                        Console.WriteLine("==============================================================");
                        Console.WriteLine("Veti fi redirectionati in meniul anterior");
                        Console.ReadKey();
                        Menu_RemoveAnAgent();
                    }
                }
            }
            else //Number doesnt exist.
            {
                Console.WriteLine("<!> Agentul cu ID-ul {0}, nu a fost gasit. \r\nVerificati corectitudinea datelor introduse si incercati din nou.", inputID);
                Console.ReadKey();
                Menu_RemoveAnAgent();
            }


        }
        public static void AddTicket()
        { 
            Console.WriteLine("]> Introduceti Numele soferului:");
            string numeSofer = Console.ReadLine();
            numeSofer = InputLimitation_OnlyText(numeSofer);
            
            Console.WriteLine("\r\nNume contravenient: " + numeSofer);
            Console.WriteLine("==============================================================");

            //==============================================================
            Console.WriteLine("]> Introduceti Prenumele soferului:");
            string prenumeSofer = Console.ReadLine();
            prenumeSofer = InputLimitation_OnlyText(prenumeSofer);

            Console.WriteLine("\r\nNume contravenient: " + prenumeSofer);
            Console.WriteLine("==============================================================");

            //============================= Cathegory =================================

            Console.WriteLine("]> Selectati categoria:");
            Console.WriteLine(
                "]>> [1] Bicicleta" +
                "\r\n]>> [2] Motoreta-motocicleta" +
                "\r\n]>> [3] Autoturism" +
                "\r\n]>> [4] Camion" +
                "\r\n]>> [5] Tractor");


            char[] catInput_01 = Console.ReadLine().ToCharArray();
            uint catInput_02 = Loop_forceToReturnPositiveNumbers(catInput_01);

            uint start = 1;
            uint end = 5;
            uint catInput = OutputConstrains_RangedSwitch(catInput_02, start, end);
            //Console.ReadKey();
            
            string categorie = null;
            switch (catInput)
            {
                case 1:
                    categorie = "Bicicleta";
                    break;
                case 2:
                    categorie = "Motoreta-motocicleta";
                    break;
                case 3:
                     categorie = "Autoturism";
                    break;
                case 4:
                     categorie = "Camion";
                    break;
                case 5:
                     categorie = "Tractor";
                    break;
                default:
                    Console.WriteLine("\r\n<!> Ati introdus o optiune inexistenta. Veti fi redirectionati in meniul anterior");
                    Console.ReadKey();
                    Menu_AddATicket();
                    break;
            }

            Console.WriteLine("==============================================================");
            Console.WriteLine("Ati ales categoria {0}", categorie);
            Console.WriteLine("==============================================================");
            Console.ReadKey();
            //Aici este posibil de adaugat un submeniu nou cu DA/NU - in caz de s-a introdus datele gresit.

            //============================= Fine Value =================================
            Console.WriteLine("]> Precizati valoarea amenzii:");
            char[] cInputValue = Console.ReadLine().ToCharArray();

            while (CheckIfNumber(cInputValue) == false)
            {
                string sInput = new string(cInputValue);
                Console.WriteLine("Ati introdus => {0}", sInput);
                Console.WriteLine("\r\n<!> Valoarea introdusa nu este valida. Introduceti doar numere. Excludeti utilizarea spatiilor, a literelor sau a simbolurilor.");
                Console.WriteLine("\r\nIncercati din nou...");
                Console.ReadKey();
                Console.WriteLine("]> Precizati valoarea amenzii:");
                char[] cInputValue_02 = Console.ReadLine().ToCharArray();
                cInputValue = cInputValue_02;
            }

            string nString = new string(cInputValue);
            uint fineValue = Convert.ToUInt32(nString);
            Console.WriteLine("Soferul {0} {1}, care se deplasa cu {2}, este amendat cu {3} RON.",numeSofer, prenumeSofer, categorie, fineValue);
            Console.ReadKey();

            Console.WriteLine("Apasati orice tasta pentru a incarca lista cu agenti.");
            Console.ReadKey(true);
            Console.Clear();
            PrintAllAgents();

            //============================= Agent ID =================================

            Console.WriteLine("]> Introduceti ID-ul agentului constatator");

            char[] cInputID = Console.ReadLine().ToCharArray();
            uint issuerID = SearchAndReturnActiveAgentID(cInputID);

            //============================= Final Confirmation =================================
            Ticket newTicket = new Ticket() { DriversName = numeSofer, DriverSurname = prenumeSofer, VehicleCathegory = categorie, FineValue = fineValue, IssuerID = issuerID };
            Console.WriteLine("==============================================================");
            Console.WriteLine("INFORMATII AMENDA:\r\nSofer: {0} {1}/ vehicul: {2}/ valoarea amenzii: {3}/ Agentul constatator: {4}", newTicket.DriversName, newTicket.DriverSurname, newTicket.VehicleCathegory, newTicket.FineValue ,newTicket.IssuerID);
            Console.WriteLine("==============================================================");
            Console.WriteLine("]> Doriti sa finalizati operatiunea ?");
            Console.WriteLine("\r\n >>>>>>> DA: 1 / NU: 2 <<<<<<< ");
            
            char[] inputAB_01 = Console.ReadLine().ToCharArray();
            if (Yes_No_navigation(inputAB_01))
            {
                Console.WriteLine("Operatiune finalizata cu succes. \r\nAmenda a fost adaugata in lista cu amenzi.");
                Console.WriteLine("Veti fi redirectionati in meniul anterior.");
                InternalData.tickets.Add(newTicket);
                Console.ReadKey();
                Menu_AddATicket();
            }
            else
            {
                Console.WriteLine("]> Doriti anularea operatiunii ? \r\nIn cazul anularii, veti fi redirectionati in meniul principal.");
                Console.WriteLine("\r\n >>>>>>> DA: 1 / NU: 2 <<<<<<< ");
                char[] inputAB_02 = Console.ReadLine().ToCharArray();
                if (Yes_No_navigation(inputAB_02))
                {
                    Menu_MainMenu();
                }
                else
                {
                    Console.WriteLine("Sunteti cam indecis astazi...");
                    Console.WriteLine("Operatiune finalizata cu succes. \r\nAmenda a fost adaugata in lista cu amenzi.");
                    Console.WriteLine("Veti fi redirectionati in meniul anterior.");
                    InternalData.tickets.Add(newTicket);
                    Console.ReadKey();
                    Menu_AddATicket();
                }
            }
        }
        public static void ListTicketsByAgent() 
        {
            PrintAllAgents();
            Console.WriteLine("]> Selectati numarul agentului:");

            char[] cInputID = Console.ReadLine().ToCharArray();

            uint ID = SearchAndReturnActiveAgentID(cInputID);
            string sID = Convert.ToString(ID);

            if (ID == 8)
            {
                //Print all the tickets attached to Virtual Agent.
            }

            if (InternalData.agents.Exists(x => x.AgentID == ID)) //Does that ID exists ?
            {
                PrintTicketsByID(ID, InternalData.tickets);
            }
            else //Number doesnt exist.
            {
                Console.WriteLine("<!> Agentul cu ID-ul {0}, nu a fost gasit. \r\nVerificati corectitudinea datelor introduse si incercati din nou.", ID.ToString());
                Console.ReadKey();
                Menu_TicketOverview_byAgent();
            }
            Console.WriteLine("\r\n Apasati orice tasta ca sa fiti transferati in meniul principal.");
            Console.ReadKey();
            Menu_MainMenu();
        }
        public static void ListTicketstByDriver() 
        {
            PrintAllTheDriversNameSurname(InternalData.tickets);

            List<Ticket> filteredByName = new List<Ticket>();
            List<Ticket> filteredBySurname = new List<Ticket>();
            uint totalAmound = 0;

            //=========================== Filter by Name ======================================

            Console.WriteLine("\r\n]> Introduceti Numele contravenientului:");

            string name = Console.ReadLine();
            name = InputLimitation_OnlyText(name);
            if (InternalData.tickets.Exists(x => x.DriversName.Equals(name)))
            {
                Console.WriteLine("==============================================================");
                Console.WriteLine("\r\nNume contravenient: " + name);
                Console.WriteLine("==============================================================");
                filteredByName = InternalData.tickets.FindAll(x => x.DriversName.Equals(name));
            }
            else
            {
                bool doesExist = false;
                int counter = 0;
                while (doesExist == false && counter < 3)
                {
                    Console.WriteLine("==============================================================");
                    Console.WriteLine("Ati introdus: \"{0}\"", name);
                    Console.WriteLine("==============================================================");
                    Console.WriteLine("<!> Numele introdus nu exista. Verificati corectitudinea datelor introduse si incercati din nou.");
                    Console.WriteLine("Au ramas {0} incercari, dupa care veti fi transferati in meniul principal.", (3 - counter));
                    Console.ReadKey();
                    Console.WriteLine("\r\n]> Introduceti numele contravenientului:");
                    name = Console.ReadLine();
                    name = InputLimitation_OnlyText(name);

                    if (InternalData.tickets.Exists(x => x.DriversName.Equals(name)) == false)
                    {
                        doesExist = false;
                    }
                    else
                    {
                        doesExist = true;
                    }
                }
                if (doesExist == false && counter == 3)
                {
                    Console.WriteLine("Ati epuizat numarul de incercari. Veti fi transferati in meniul principal.");
                    Menu_MainMenu();
                }

                //Name does exist => a list with drivers will be created.
                Console.WriteLine("==============================================================");
                Console.WriteLine("\r\nNume contravenient: " + name);
                Console.WriteLine("==============================================================");
                filteredByName = InternalData.tickets.FindAll(x => x.DriversName.Equals(name));
                Console.ReadKey();
            }

            //=========================== Filter by Surname ======================================

            Console.WriteLine("\r\n]> Introduceti Prenumele contravenientului:");

            string surname = Console.ReadLine();
            surname = InputLimitation_OnlyText(surname);

            if (InternalData.tickets.Exists(x => x.DriverSurname.Equals(surname)))
            {
                Console.WriteLine("==============================================================");
                Console.WriteLine("\r\nPrenume contravenient: " + surname);
                Console.WriteLine("==============================================================");
                filteredBySurname = filteredByName.FindAll(x => x.DriverSurname.Equals(surname));
            }
            else
            {
                bool doesExist = false;
                int counter = 0;
                while (doesExist == false && counter < 3)
                {
                    Console.WriteLine("==============================================================");
                    Console.WriteLine("Ati introdus: \"{0}\"", surname);
                    Console.WriteLine("==============================================================");
                    Console.WriteLine("<!> Preumele introdus nu exista. Verificati corectitudinea datelor introduse si incercati din nou.");
                    Console.WriteLine("Au ramas {0} incercari, dupa care veti fi transferati in meniul principal.", (3 - counter));
                    Console.ReadKey();
                    Console.WriteLine("\r\n]> Introduceti numele contravenientului:");
                    surname = Console.ReadLine();
                    surname = InputLimitation_OnlyText(surname);

                    if (InternalData.tickets.Exists(x => x.DriverSurname.Equals(surname)) == false)
                    {
                        doesExist = false;
                    }
                    else
                    {
                        doesExist = true;
                    }
                }
                if (doesExist == false && counter == 3)
                {
                    Console.WriteLine("Ati epuizat numarul de incercari. Veti fi transferati in meniul principal.");
                    Menu_MainMenu();
                }

                //Surame does exist => a list with drivers will be created.
                Console.WriteLine("==============================================================");
                Console.WriteLine("\r\nNume contravenient: " + surname);
                Console.WriteLine("==============================================================");
                filteredBySurname = filteredByName.FindAll(x => x.DriverSurname.Equals(surname));
                Console.ReadKey();
            }

            Console.WriteLine("Contravenient:   {0} {1}", name, surname);
            Console.WriteLine("==============================================================");

            //=================================== Printing all the tickets ==================
            foreach (Ticket t in filteredBySurname)
            {
                Console.WriteLine("CATEGORIE: {0} / AGENT CONSTATATOR: {1} / VALOAREA AMENZII: {2}", t.VehicleCathegory, t.IssuerID, t.FineValue);
                totalAmound = +t.FineValue;
            }
            Console.WriteLine("==============================================================");
            Console.WriteLine("              TOTAL:   {0}", totalAmound.ToString());
            Console.WriteLine("==============================================================");
            Console.WriteLine("Apasati orice tasta, pentru a reveni la meniul anterior.");
            Console.ReadKey();
            Menu_TicketOverview_byDriver();
        }
        public static void ListAllTicketsByValue() 
        {
            uint grandTotal = 0;

            foreach (Agent agent in InternalData.agents)
            {
                uint totalAmound = 0;
                List <Ticket> tickets = InternalData.tickets.FindAll(x =>x.IssuerID.Equals(agent.AgentID));
                foreach(Ticket t in tickets)
                {
                    totalAmound += t.FineValue;
                }
                agent.TotalAmound = totalAmound;
            }
            List<Ticket> vTickets = InternalData.tickets.FindAll(x => x.IssuerID.Equals(InternalData.virtualAgent.AgentID));
            uint vAgentTotalAmound = 0;
            foreach (Ticket t in vTickets)
            {
                vAgentTotalAmound += t.FineValue;
            }
            InternalData.virtualAgent.TotalAmound = vAgentTotalAmound;
            
            List <Agent> allAgents = new List<Agent>();
            allAgents.Add(InternalData.virtualAgent);
            allAgents.AddRange(InternalData.agents);

            allAgents.Sort((a1, a2) => { return a2.TotalAmound.CompareTo(a1.TotalAmound); });
            
            Console.WriteLine("]AGENT: ================= SUMA TOTAL AMENZI: =================");
            foreach (Agent agent in allAgents)
            {
                Console.WriteLine("| {0} {1} ===> {2} RON", agent.Name, agent.Surname, agent.TotalAmound);
                grandTotal += agent.TotalAmound;
            }
            Console.WriteLine("\r\n==============================================================");
            Console.WriteLine("GRAND TOTAL: {0} RON", grandTotal);
            Console.WriteLine("==============================================================");
            Console.WriteLine("\r\nApasati orice tasta ca sa fiti transferati in meniul principal");
            Console.ReadKey();
            Menu_MainMenu();
        }
        public static void CloseTheProgram()
        {
            Environment.Exit(0);
        }

        ///////////// Secondary actions /////////////
        public static string InputLimitation_OnlyText(string inputText)
        {
            char[] input = inputText.ToCharArray();
            if (CheckIfLetters(input))
            {
                return inputText;
            }
            else
            {
                int counter = 0;
                while (CheckIfLetters(input) == false && counter < 3)
                {
                    Console.WriteLine("Ati introdus => {0}", inputText);
                    Console.WriteLine("\r\n<!> Valorile introduse nu sunt valide. Excludeti utilizarea spatiilor, a cifrelor sau a simbolurilor.");
                    Console.WriteLine("\r\nAu ramas {0} incercari, dupa care veti fi transferati in meniul principal.", (3 - counter));
                    Console.ReadKey();
                    Console.WriteLine("]> Introduceti Numele soferului:");
                    inputText = Console.ReadLine();
                    input = inputText.ToCharArray();
                    counter++;
                }
                if (CheckIfLetters(input) == false && counter == 3)
                {
                    Console.WriteLine("<!> Ati epuizat numarul de incercari. Veti fi transferati in meniul principal.");
                    Menu_MainMenu();
                }
            }
            return inputText;
        }
        public static void PrintAllAgents()
        {
            Console.WriteLine("\r\n============================== AGENT VIRTUAL ==============================");
            Console.WriteLine("| {0} {1}   ID: {2}", InternalData.virtualAgent.Name, InternalData.virtualAgent.Surname, InternalData.virtualAgent.AgentID);

            Console.WriteLine("\r\n============================== AGENTI ACTIVI ==============================");
            foreach (Agent agent in InternalData.agents)
            {
                Console.WriteLine("| {0} {1}   ID: {2}", agent.Name, agent.Surname, agent.AgentID);
            }
            Console.WriteLine("\r\n===========================================================================");
        }
        public static void PrintAllTheTickets( List<Ticket> collection)
        {
            Console.WriteLine("]AGENT ID: || DRIVER: === VEHIVLE: === FINE:");
            foreach (Ticket ticket in collection) 
            {
                Console.WriteLine("| {3}   || {0} {1}   {2}   {4} RON", ticket.DriversName, ticket.DriverSurname, ticket.VehicleCathegory, ticket.IssuerID ,ticket.FineValue);
            }
            Console.ReadKey();
        }
        public static void PrintRetiredAgents()
        {
            Console.WriteLine("\r\n============================= AGENTI INACTIVI =============================");
            foreach (Agent rAgent in InternalData.retiredAgents)
            {
                Console.WriteLine("| {0} {1}   ID: {2}", rAgent.Name, rAgent.Surname, rAgent.AgentID);
            }
            Console.WriteLine("\r\n===========================================================================");
        }
        public static void PrintTicketsByID(uint ID, List<Ticket> collection)
        {
            uint totalAmound = 0;
            Console.WriteLine("==============================================================");
            foreach (Ticket t in collection)
            {
                if (t.IssuerID == ID)
                {
                    string printID = Convert.ToString(t.IssuerID);
                    string printFineValue = Convert.ToString(t.FineValue);
                    Console.WriteLine("SOFER: [{1} {2}] VEHICUL: [{3}] ID AGENT CONSTATATOR: [{0}] VALOAREA AMENZII: [{4}]", printID, t.DriversName, t.DriverSurname, t.VehicleCathegory, printFineValue);
                    totalAmound += t.FineValue;
                }
            }
            Console.WriteLine("==============================================================");
            Console.WriteLine("TOTAL: {0}",totalAmound.ToString());
            Console.WriteLine("==============================================================");
        }
        public static void PrintAllTheDriversNameSurname(List <Ticket> collection) 
        {
            foreach(Ticket t in collection)
            {
                Console.WriteLine("NUME: {0}   PRENUME: {1}", t.DriversName, t.DriverSurname);
            }
        }        
        public static string ChoseVehicleCathegory(char[] charInput)
        {
            string cat = null;
            while (charInput.Length != 1)
            {
                Console.WriteLine("\r\n<!> Valoarea introdusa nu este valida. Introduceti doar numere, excludeti utilizarea spatiilor, a literelor sau a simbolurilor.");
                Console.WriteLine("Incercati din nou...");
                Console.ReadKey();
                Console.WriteLine("]> Selectati categoria:");
                char[] cInputCat_2 = Console.ReadLine().ToCharArray();
                charInput = cInputCat_2;
            }

            char symbol = charInput[0];
            int i = symbol - '0';

            switch (i)
            {
                case 1:
                    cat = "Bicicleta";
                    break;
                case 2:
                    cat = "Motoreta-motocicleta";
                    break;
                case 3:
                    cat = "Autoturism";
                    break;
                case 4:
                    cat = "Camion";
                    break;
                case 5:
                    cat = "Tractor";
                    break;
                default:
                    Console.WriteLine("\r\n<!> Input inexistent");
                    Console.WriteLine("Incercati din nou...");
                    Console.ReadKey();
                    charInput = Console.ReadLine().ToCharArray();
                    ChoseVehicleCathegory(charInput);
                    break;
            }
            return cat;
        }
        public static uint InputAnID(char[] charInput)
        {
            int counter = 0;
            while (CheckIfNumber(charInput) == false && counter <3)
            {
                Console.WriteLine("Ati introdus => {0}", charInput);
                Console.WriteLine("\r\n<!> Numarul introdus nu este valid. Introduceti doar numere. Excludeti utilizarea spatiilor, a literelor sau a simbolurilor.");
                Console.WriteLine("\r\nAu ramas {0} incercari, dupa care veti fi transferati in meniul principal.", (3 - counter));
                Console.ReadKey();
                Console.WriteLine("]> Introduceti ID-ul agentului.");
                char[] cInput = Console.ReadLine().ToCharArray();
                charInput = cInput;
                counter++;
            }
            if(CheckIfNumber(charInput) == false && counter == 3)
            {
                Console.WriteLine("<!> Ati epuizat numarul de incercari. Veti fi transferati in meniul principal.");
                Menu_MainMenu();
            }
            string idToString = new string(charInput);
            uint inputID = Convert.ToUInt32(idToString);
            return inputID;
        }
        public static uint SearchAndReturnActiveAgentID(char[] charInput)
        {
            uint agentID = InputAnID(charInput);
            int counter = 0;
            
            if(agentID ==8)
            {
                return agentID;
            }

            while (ChechIfAgentIDExists(agentID) == false && counter < 3)
            {
                Console.WriteLine("Ati introdus => {0}", charInput);
                Console.WriteLine("\r\n<!> ID-ul introdus nu exista.");
                Console.WriteLine("\r\nAu ramas {0} incercari, dupa care veti fi transferati in meniul principal.", (3 - counter));
                Console.ReadKey();
                Console.WriteLine("]> Introduceti ID-ul agentului.");
                char[] cInput = Console.ReadLine().ToCharArray();
                charInput = cInput;
                agentID = InputAnID(charInput);
                counter++;
            }
            if (counter == 3 && ChechIfAgentIDExists(agentID) == false)
            {
                Console.WriteLine("Ati epuizat numarul de incercari. Veti fi transferati in meniul principal.");
                Menu_MainMenu();
            }
            return agentID;
        }



        ///////////// Checkers /////////////
        public static bool CheckIfNumber(char[] input) //Returns only positive numbers, starting with Zero. Iteration detects if there are any other symbols byt digits.
        {
            if (input.Length <= 0) //input null
            {
                Console.WriteLine("\r\n<!> Nu a fost introdus nicio valoare");
                return false;
            }

            bool result = false;
            foreach(char c in input) //checks in there are non digit elements in the array.
            {
                result = Char.IsDigit(c);
                if(result == false)
                {
                    return false;
                }
            }
            return result;
        }
        public static bool CheckIfLetters(char[] input) 
        {
            if (input.Length <= 0)
            {
                Console.WriteLine("\r\n<!> Nu a fost introdus nicio valoare");
                return false;
            }

            bool result = false;
            foreach (char c in input)
            {
                result = Char.IsLetter(c);
                if (result == false)
                {
                    return false;
                }
            }
            return result;
        }
        public static bool Yes_No_navigation(char[] userInput) 
        {
            if (CheckIfNumber(userInput)) {
                if (userInput.Length > 1)
                {
                    Console.WriteLine("\r\n<!> Input incorect - ati introdus mai multe numere.");
                    Console.WriteLine("Mai incercati odata.");
                    Console.ReadKey();
                    Console.WriteLine(">>>>>>> DA: 1 / NU: 2 <<<<<<< ");
                    char[] newInput = Console.ReadLine().ToCharArray();
                    Yes_No_navigation(newInput);
                    //return false;
                }
                else
                {
                    userInput[0] -= '0';
                    if (userInput[0] == 1)
                    {
                        return true;
                    }
                    else
                    {
                        if (userInput[0] == 2)
                        {
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("\r\n<!> Input incorect - ati introdus o optiune inexistenta. \r\n  Mai incercati odata..");
                            Console.ReadKey();
                            Console.WriteLine(">>>>>>> DA: 1 / NU: 2 <<<<<<< ");
                            char[] newInput = Console.ReadLine().ToCharArray();
                            Yes_No_navigation(newInput);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("\r\n<!> Input incorect - ati introdus simboluri sau litere. \r\n Mai incercati odata.");
                Console.ReadKey();
                Console.WriteLine(">>>>>>> DA: 1 / NU: 2 <<<<<<< ");
                char[] newInput = Console.ReadLine().ToCharArray();
                Yes_No_navigation(newInput);
            }
            return false;
        }
        public static bool ChechIfAgentIDExists(uint id)
        {
            if (InternalData.agents.Exists(x => x.AgentID == id))
            {
                return true;
            }
            return false;
        }
        public static uint OutputConstrains_RangedSwitch(uint input, uint start, uint end) 
        {
            uint output;
            bool inRange = false;
            int counter = 0;
            string sInput = input.ToString();
            char[] newInput;

            if(input >= start && input <= end)
            {
                inRange = true;
            }
            else
            {
                inRange = false;
            }

            while (inRange == false && counter < 3)
            {
                Console.WriteLine("Ati introdus => {0}", sInput);
                Console.WriteLine("\r\n<!> Valoarea introdusa nu este valida. Introduceti doar numerele corespunzatoare optiunilor afisate.");
                Console.WriteLine("Au ramas {0} incercari, dupa care veti fi transferati in meniul principal.", (3 - counter));
                Console.WriteLine("\r\n]> Introduceti numarul corespunzator operatiunii dorite:");
                newInput = Console.ReadLine().ToCharArray();
                input = Loop_forceToReturnPositiveNumbers(newInput);
                sInput = input.ToString();
                counter++;
                
                if (input >= start && input <= end)
                {
                    inRange = true;
                }
                else
                {
                    inRange = false;
                }
            }

            if (inRange == false && counter == 3)
            {
                Console.WriteLine("Ati epuizat numarul de incercari. Veti fi transferati in meniul principal.");
                Menu_MainMenu();
            }

            output = input;
            return output;
        }
        public static uint Loop_forceToReturnPositiveNumbers(char [] input) //Zero based numbers
        {
            uint output = new uint();
            string sInput = new string(input);
            int counter = 0;
            while(CheckIfNumber(input) == false && counter < 3) //if it is a number, this block will be ignored.
            {
                Console.WriteLine("Ati introdus => {0}", sInput);
                Console.WriteLine("\r\n<!> Valoarea introdusa nu este valida. Introduceti doar numere intregi si pozitive. Excludeti utilizarea spatiilor, a literelor sau a simbolurilor.");
                Console.WriteLine("Au ramas {0} incercari, dupa care veti fi transferati in meniul principal.", (3 - counter));
                Console.WriteLine("\r\n]> Introduceti valoarea numerica dorita:");
                input = Console.ReadLine().ToCharArray();
                sInput = new string(input);
                counter++;
            }
            if (CheckIfNumber(input) == false && counter == 3) //If input is false and you tryed 3 times, this block will be executed.
            {
                Console.WriteLine("<!> Ati epuizat numarul de incercari. Veti fi transferati in meniul principal.");
                Menu_MainMenu();
            }
            output = Convert.ToUInt32(sInput);
            return output;
        }
        ///////////// Features /////////////
        //public static void RemoveTicket() { }
    }
}
