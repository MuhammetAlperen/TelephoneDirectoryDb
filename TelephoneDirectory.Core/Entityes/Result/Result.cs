using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Entityes.Result.Base;

namespace TelephoneDirectory.Core.Entityes.Result
{
    public class Result<T> : IResult<T>
    {
        #region Result prop.
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        #endregion
    }
}
