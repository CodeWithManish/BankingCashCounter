using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCashCounter
{
    public class CashCounter
    {
        int deposit = 0;
        int withdraw =0;
        double totalBalance = 1000;

        QueueClass queue=new QueueClass();
        public void Deposit()
        {
            Console.WriteLine("Total Amount of your Account:" + totalBalance);
            Console.WriteLine("Enter Deposit Amount: ");
            deposit = Convert.ToInt32(Console.ReadLine());
            totalBalance = totalBalance + deposit;
            System.Console.WriteLine(deposit + " deposit money in your account\n");
            System.Console.WriteLine("Current Avaialble Balance is :" + totalBalance);
            
            queue.Dequeue();
        }
        
        public void Withdraw()
        {
            Console.WriteLine("Total Amount of your Account:" + totalBalance);
            Console.WriteLine("Enter Withdraw Amount: ");
            withdraw =Convert.ToInt32(Console.ReadLine());
            if (withdraw > totalBalance)
            {
                System.Console.WriteLine("Withdraw Amount does not Exist your Account\n");
            }
            else
            {
                totalBalance = totalBalance - withdraw;
                System.Console.WriteLine(withdraw + "Amount withdraw from your Account\n");
                System.Console.WriteLine("Current Avaialble Balance is :"+ totalBalance);
            }
            queue.Dequeue();
        }
       
    }
}
