using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount <string,double> bankAccount = new BankAccount <string,double> ();
            bankAccount.AccountInformation("1267-005-776",59788.56);
            Console.ReadKey();
            BankAccount<int, double> bankAccount2 = new BankAccount<int, double>();
            bankAccount.AccountInformation("12677453", 113456.89);
            Console.ReadKey();


        }


    }

    public class BankAccount<T,U>
    {
        T accountNumber;
       U balanceNumber;
        string fullName;


        public T AccountNumber {get;set;}
        public U BalanceNumber { get; set; }

        public string FullName { get; set; }

       public BankAccount() 
        {
            accountNumber = AccountNumber;
            balanceNumber = BalanceNumber;
            fullName = FullName;
  
        }

        public void AccountInformation(T value,U value2) 
        {
            Console.WriteLine("Введите ФИО владельца счета");
            FullName= Console.ReadLine();

            AccountNumber = value;
          Console.WriteLine("Номер счета: {0}",value);     
            BalanceNumber = value2;
            Console.WriteLine("Баланс счета: {0}", value2);

        }
         
    }


}
