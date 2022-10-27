using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInfo
{
    public abstract class Account
    {
        public abstract long ID { get; set; }
        public abstract string Name { get; set; }
        public abstract long AccountNumber { get; set; }
        public abstract DateTime CreateDate { get; set; }
        public abstract string AccountType { get; set; }
        public abstract double Balance { get; set; }
    }
    public enum AccountType
    {
        Savings_Account = 1,
        Student_Account = 2,
        Silver_Account = 3,
        Gold_Account = 4,
        Platinum_Account = 5
    }
}
