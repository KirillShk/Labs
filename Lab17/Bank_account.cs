using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Bank_account<T>
    {
        private string numAccount { get; set; }
        private double balanceAccount { get; set; }
        private string Name { get; set; }
        T Typeaccount { get; set; }


        public string Numaccount
        {
            get { return numAccount; }
            set
            {
                int b = (value.Replace(" ", "").Length);
                if (b != 20)
                    numAccount = "Номер счета должен состоять из 20-ти цифр!";
                else
                    numAccount = value;
            }
        }
        public double Balanceaccount
        {
            get { return balanceAccount; }
            set
            {
                if (value < 0)
                    balanceAccount = 0;
                else
                    balanceAccount = value;
            }
        }

        public Bank_account(string numaccount, string accountname, double balanceaccount, T typeaccount)
        {
            this.Numaccount = numaccount;
            this.Balanceaccount = balanceaccount;
            this.Name = accountname;
            Typeaccount = typeaccount;
        }
        public string GetInfo()
        {
            return $"Номер счета - {numAccount},\n ФИО клиента {Name},\n Баланс - {balanceAccount},\n Тип номера счета -{Typeaccount}";
        }
    }
}
}
