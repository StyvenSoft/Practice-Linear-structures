using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3HugoEcheverri.World.Queue
{
    class Ticket
    {
        // Atributos
        private int numberFlight;
        private int idClient;
        private String nameClient;
        private String airline;
        private String destinyCities;
        private String dateTravel;

        public int NumberFlight
        {
            get
            {
                return numberFlight;
            }

            set
            {
                numberFlight = value;
            }
        }

        public int IdClient
        {
            get
            {
                return idClient;
            }

            set
            {
                idClient = value;
            }
        }

        public string NameClient
        {
            get
            {
                return nameClient;
            }

            set
            {
                nameClient = value;
            }
        }

        public string Airline
        {
            get
            {
                return airline;
            }

            set
            {
                airline = value;
            }
        }

        public string DestinyCities
        {
            get
            {
                return destinyCities;
            }

            set
            {
                destinyCities = value;
            }
        }

        public string DateTravel
        {
            get
            {
                return dateTravel;
            }

            set
            {
                dateTravel = value;
            }
        }


        // Metodo constructor
        public Ticket(int numberFlight, int idClient, String nameClient,
                String airline, String destinyCities, String dateTravel)
        {
            this.numberFlight = numberFlight;
            this.idClient = idClient;
            this.nameClient = nameClient;
            this.airline = airline;
            this.destinyCities = destinyCities;
            this.dateTravel = dateTravel;
        }
    }
}
