using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInfo
{
    sealed class AccountDetails<T> : Account, IBalance<T>
    {
        public override long ID { get; set; }
        public override string Name { get; set; }
        public override long AccountNumber { get; set; }
        public override DateTime CreateDate { get; set; }
        public override string AccountType { get; set; }
        public override double Balance { get; set; }

        public void GetBalance(T amount)
        {
            if (amount != null)
            {
                this.Balance = Convert.ToDouble(amount);
            }
            else
                Balance = 0;
        }
    }
}
