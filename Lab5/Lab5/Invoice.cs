using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Invoice : INumber, IInformation
    {
        private string numberOfinvoice;
        private int address;  //
        private string reciverName;
        private string senderName;
        private int count;
        public string NumberOfinvoice { get => numberOfinvoice; set => numberOfinvoice = value; }
        public int Address { get => address; set => address = value; }
        public string ReciverName { get => reciverName; set => reciverName = value; }
        public string SenderName { get => senderName; set => senderName = value; }
        public int Count { get => count; set => count = value; }

        public Invoice(string numberOfinvoice, int address, string reciverName, string senderName, int count)
        {
            NumberOfinvoice = numberOfinvoice;
            Address = address;
            ReciverName = reciverName;
            SenderName = senderName;
            Count = count;
        }

        public Invoice()
        {

        }
        public void Output_invoice()
        {
            Console.WriteLine("NumberOfinvoice: " + NumberOfinvoice + "\nDate: " + Address + "\nReciverName : " + ReciverName + "\nSenderName: " + SenderName + "\nCount: " + Count);
        }
        public void Edit_Invoice()
        {
            Console.Clear();
            Console.WriteLine("Change the count of invoice:\n");
            Count = Convert.ToInt32(Console.ReadLine());
        }
    }
}
