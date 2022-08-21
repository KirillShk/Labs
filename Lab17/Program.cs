using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер счета");
            string numaccount = Console.ReadLine();
            Console.WriteLine("Введите ФИО");
            string accountname = Console.ReadLine();
            Console.WriteLine("Введите баланс счета");
            double balanceaccount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите тип счета");
            int typeaccountInt = Convert.ToInt32(Console.ReadLine());
            Bank_account<int> client1 = new Bank_account<int>(numaccount, accountname, balanceaccount, typeaccountInt);
            Console.WriteLine(client1.GetInfo());
            Console.WriteLine("Введите номер счета");
            numaccount = Console.ReadLine();
            Console.WriteLine("Введите ФИО");
            accountname = Console.ReadLine();
            Console.WriteLine("Введите баланс счета");
            balanceaccount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите тип счета");
            string typeaccountString = Console.ReadLine();
            Bank_account<string> client2 = new Bank_account<string>(numaccount, accountname, balanceaccount, typeaccountString);
            Console.WriteLine(client2.GetInfo());
            Console.ReadKey();
        }
    }
}
