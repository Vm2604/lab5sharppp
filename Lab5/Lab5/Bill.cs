using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Bill : Document
    {
        private string result;
        public string Result { get => result; set => result = value; }
      
        public Bill(string numberOfinvoice, int address, string reciverName, string senderName, int count, int payed, int total_summ, string result)
            : base(numberOfinvoice, address, reciverName, senderName, count, payed, total_summ)
        {
            Result = result;
        }

        public Bill()
        {

        }
        public void Output_Bill()
        {
            Console.WriteLine("\nBill: " + Result);
        }
        public void Edit_Bill()
        {
            Console.Clear();
            Console.WriteLine("New Bill:\n");
            Result = Console.ReadLine();
        }
    }
}
