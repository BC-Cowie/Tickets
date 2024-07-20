using System;
using System.Collections.Generic;


namespace Tickets
{
    internal class Concert
    {
        private string _bandName;
        //properties
        public string bandName
        {
            get { return _BandName; }
            set { _BandName = value; }
        }

        //constructor
        private List<ConcertTicket> _concertTickets;
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
            foreach (ConcertTicket ct in _concertTicket)
            {
                Console.WriteLine(ct.OutputStatus());
            }
        }
    }
}
