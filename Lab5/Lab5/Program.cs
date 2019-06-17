using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program //
    {
        delegate void Method();

        static void Edit(Bill lasttest)
        {
            int choice = 0;
            Console.WriteLine("MENU (make your choice): (1 - Count || 2 - Correct Waybill || 3 - Total summ || 4 - Results)\n");
            choice = Convert.ToInt32(Console.ReadLine());
            Method edit;
            switch (choice)
            {
                case 1:
                    edit = lasttest.Edit_Invoice;
                    edit();
                    break;
                case 2:
                    edit = lasttest.Edit_Waybill;
                    edit();
                    break;
                case 3:
                    edit = lasttest.Edit_Document;
                    edit();
                    break;
                case 4:
                    edit = lasttest.Edit_Bill;
                    edit();
                    break;
                default:
                    Console.WriteLine("Error input");
                    break;
            }
        }
        static void Print(Bill lasttest)
        {
            Method pointer;
            pointer = lasttest.Output_invoice;
            pointer += lasttest.Output_Waybill;
            pointer += lasttest.Output_Document;
            pointer += lasttest.Output_Bill;
            pointer();
        }

        static void Main(string[] args)
        {
            int selection = 0;
            Bill lasttest = new Bill("№1424242", 25, "Penchev Mike", "Somebody", 1, 30, 24, "Payed");

            Print(lasttest);

        Link:
            Console.WriteLine("\nYou can change the information. Do you want to do it?(Yes - 1 | Exit - 2)");
            selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Edit(lasttest);
                    Print(lasttest);
                    goto Link;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nError input!");
                    goto Link;
            }
            Console.ReadKey();
        }
    }
}
