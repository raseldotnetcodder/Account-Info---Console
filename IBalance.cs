using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInfo
{
    public interface IBalance<T>
    {
        void GetBalance(T amount);
    }
}
