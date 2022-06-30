using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public partial class BankAccount
    {
        public void Show()
        {
            Console.WriteLine($"Head Office {HeadOffice}");
            Console.WriteLine($"IBAN TITLE : {IBANTitle}");
            Console.WriteLine($"No {No}");
            Console.WriteLine($"Bank name {BankName}");
        }

        partial void Update()
        {
            Console.WriteLine("Balans 1230  , 30 manat chixildin");
        }


        public void CallUpdate()
        {
            Update();
        }
    }
}
