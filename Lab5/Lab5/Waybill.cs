using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Waybill : Invoice
    {
        private int payed;
        public int Payed { get => payed; set => payed = value; }

        public Waybill(string numberOfinvoice, int address, string reciverName, string senderName, int count, int payed)
            : base(numberOfinvoice, address, reciverName, senderName, count)
        {
            Payed = payed;
        }

        public Waybill()
        {

        }
        public void Output_Waybill()
        {
            Console.WriteLine("\nPayed: " + Payed);
        }
        public void Edit_Waybill()
        {
            Console.Clear();
            Console.WriteLine("Change payed summ :\n");
            Payed = Convert.ToInt32(Console.ReadLine());
        }
    }
}
