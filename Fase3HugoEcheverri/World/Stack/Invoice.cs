using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3HugoEcheverri.World.Stack
{
    public class Invoice
    {
        // Atributos
        private String numInvoice;
        private String numEnrollment;
        private String monthBilled;
        private String userName;
        private String address;
        private int stratum;
        private String category;
        private double consumMonth;

        // Metodo constructor
        public Invoice(String numInvoice, String numEnrollment, String monthBilled,
                String userName, String address, int stratum, String category,
                double consumMonth)
        {
            this.numInvoice = numInvoice;
            this.numEnrollment = numEnrollment;
            this.monthBilled = monthBilled;
            this.userName = userName;
            this.address = address;
            this.stratum = stratum;
            this.category = category;
            this.consumMonth = consumMonth;
        }

        public string NumInvoice
        {
            get
            {
                return numInvoice;
            }

            set
            {
                numInvoice = value;
            }
        }

        public string NumEnrollment
        {
            get
            {
                return numEnrollment;
            }

            set
            {
                numEnrollment = value;
            }
        }

        public string MonthBilled
        {
            get
            {
                return monthBilled;
            }

            set
            {
                monthBilled = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public int Stratum
        {
            get
            {
                return stratum;
            }

            set
            {
                stratum = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public double ConsumMonth
        {
            get
            {
                return consumMonth;
            }

            set
            {
                consumMonth = value;
            }
        }


        // Metodo ToString
        override
        public String ToString()
        {
            return "Factura [numFactura=" + numInvoice + ", numMatricula=" + numEnrollment + ", mesfacturado=" + monthBilled
                    + ", nombre=" + userName + ", direccion=" + address + ", estrato=" + stratum + ", categoria="
                    + category + ", mts3Consumidos=" + consumMonth + "]";
        }
    }
}
