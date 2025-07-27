
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Hesabı_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            bool isRunning = true;

            while (isRunning)
            {
                ShowMenu();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Lütfen Bir Menü Seçiniz: ");
                Console.ResetColor();

                char choice;
                if (!char.TryParse(Console.ReadLine(), out choice))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Geçersiz giriş! Lütfen bir karakter giriniz.");
                    Console.ResetColor();
                    continue;
                }

                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Hesap Numaranız: {account.AccountNumber}");
                        Console.ResetColor();
                        break;

                    case '2':
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Hesap Bakiyeniz: {account.Balance}");
                        Console.ResetColor();
                        break;

                    case '3':
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Yüklemek İstediğiniz Tutarı Giriniz: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            account.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Geçersiz miktar girişi!");
                            Console.ResetColor();
                        }
                        break;

                    case '4':
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Çekmek İstediğiniz Tutarı Giriniz: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                        {
                            account.Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Geçersiz miktar girişi!");
                            Console.ResetColor();
                        }
                        break;

                    case '5':
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Çıkış Yapılıyor...");
                        Console.ResetColor();
                        isRunning = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Hatalı Seçim Yaptınız!!");
                        Console.ResetColor();
                        break;
                }

                Console.WriteLine();
            }
        }

        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("1. Hesap Numarası Görüntüle");
            Console.WriteLine("2. Bakiye Görüntüle");
            Console.WriteLine("3. Para Yükle");
            Console.WriteLine("4. Para Çek");
            Console.WriteLine("5. Çıkış");
            Console.ResetColor();
        }
    }
}

