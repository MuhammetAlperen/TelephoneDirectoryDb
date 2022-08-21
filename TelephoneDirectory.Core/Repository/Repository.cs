using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Repository.Base;

namespace TelephoneDirectory.Core.Repository
{
    public class Repository<T>: IRepository<T> where T : class
    {
    }
}
