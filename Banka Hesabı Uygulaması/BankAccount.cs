using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Hesabı_Uygulaması
{
    internal class BankAccount
    {
        private string _accountNumber = "1234567890";
        private decimal _balance;
        private string _owner;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public string Owner
        {
            get { return _owner; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Sahip İsmi Boş Bırakılamaz Veya Sadece Boşluk Kullanılamaz!!");
                    Console.ResetColor();
                }
                else
                {
                    _owner = value;
                }
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Geçersiz miktar. Pozitif bir değer giriniz.");
                Console.ResetColor();
                return;
            }

            _balance += amount;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Yüklenen Bakiye: {amount}\nGüncel Bakiye: {_balance}");
            Console.ResetColor();
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Geçersiz miktar. Pozitif bir değer giriniz.");
                Console.ResetColor();
                return;
            }

            if (_balance < amount)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Bakiyeniz Yetersiz. Lütfen Tekrar Deneyin!!!");
                Console.ResetColor();
                return;
            }

            _balance -= amount;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Çekilen Bakiye: {amount}\nGüncel Bakiye: {_balance}");
            Console.ResetColor();
        }
    }

}
