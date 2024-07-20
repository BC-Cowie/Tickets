/*Changes: -Unnecessary using directives have been removed
           -Camelcase is better (according to microssoft) so some variables have changeed
           -Exception message has been changed/imoroved
           -Concert renamed to concertTickets (makes more sense, it's more specific)
*/
using System;
using System.Collections.Generic;


namespace Tickets
{
    internal class Concert
    {
        private string _bandName;
        private List<ConcertTicket> _concertTickets;
        
        //properties
        public string BandName
        {
            get { return _bandName; }
            set { _bandName = value; }
        }


        public Concert(string name)
        {
            BandName = name;
            _concertTickets = new List<ConcertTicket>();
        }

        //methods
        public void AddConcertTicket(ConcertTicket ct)
        {
            if (ct.ConcertName != BandName)
            {
                throw new WrongConcertException("Sorry - this is the wrong concert" + ct.ConcertName);
            }
            else
            {
                _concertTickets.Add(ct);
            }
        }

        public void OutputAllSeats()
        {
            foreach (ConcertTicket ct in _concertTickets)
            {
                Console.WriteLine(ct.OutputStatus());
            }
        }
    }
}
