using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Document : Waybill
    {
        private int total_summ;
        public int Total_summ { get => total_summ; set => total_summ = value; }

       
        public Document(string numberOfinvoice, int address, string reciverName, string senderName, int count, int payed, int total_summ)
           : base(numberOfinvoice, address, reciverName, senderName, count, payed)
        {
            Total_summ = total_summ;
        }

        public Document()
        {

        }
        public void Output_Document()
        {
            Console.WriteLine("\nTotal Summ: " + Total_summ);
        }
        public void Edit_Document()
        {
            Console.Clear();
            Console.WriteLine("Change the totalsumm:\n");
            Total_summ = Convert.ToInt32(Console.ReadLine());
        }
    }

}
