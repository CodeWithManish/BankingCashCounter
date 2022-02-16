using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCashCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Banking Cash Counter");
            
            CashCounter counter = new CashCounter();
            QueueClass queue = new QueueClass();

            Random random = new Random();
            int user = random.Next(1, 11);
            System.Console.WriteLine(user + " Users are in Cash Counter queue ");

            System.Console.WriteLine("Press 1. Deposit\nPress 2.Withdraw\n ");
                                               
            for (int i = 1; i <= user; i++)
            {
                int check = Convert.ToInt32(Console.ReadLine());

                switch (check)
                {
                    case 1:
                        queue.Enqueue(i);
                        counter.Deposit();
                        break;

                    case 2:
                        queue.Enqueue(i);
                        counter.Withdraw();
                        break;

                    default:
                        System.Console.WriteLine("Invalid Selection!");
                        break;
                }
            }
        }
    }
}
