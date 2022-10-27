using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Account ID  : ");
            long id = Convert.ToInt64(Console.ReadLine());
            Console.Write("Name        : ");
            string name = Console.ReadLine();
            Console.Write("Account No  : ");
            long accountNo = Convert.ToInt64(Console.ReadLine());
            Console.Write("Create Date : ");
            DateTime createDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("1. Savings Account\n2. Student Account\n3. Silver Account\n4. Gold Account\n5. Platinum Account\n");
            Console.Write("Account Type: ");
            int accountType = Convert.ToInt32(Console.ReadLine());
            Console.Write("Balance     : ");
            double balance = Convert.ToDouble(Console.ReadLine());

            AccountDetails<Account> user = new AccountDetails<Account>
            {
                ID = id,
                Name = name,
                AccountNumber = accountNo,
                CreateDate = createDate,
                AccountType = Enum.GetName(typeof(AccountType), accountType)
            };
            AccountDetails<double> bl = new AccountDetails<double>();
            bl.GetBalance(balance);

            Console.WriteLine($"\n\n===============\nAccount Details\n===============\n" +
                $"Account ID  : {user.ID}\n" +
                $"Name        : {user.Name}\n" +
                $"Account No  : {user.AccountNumber}\n" +
                $"Create Date : {user.CreateDate}\n" +
                $"Account Type: {user.AccountType}\n" +
                $"Balance     : {bl.Balance}");

            Console.ReadKey();
        }
    }
}
