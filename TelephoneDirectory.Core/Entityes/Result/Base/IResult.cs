using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Core.Entityes.Result.Base
{
    public interface IResult<T>
    {
        #region prop.
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        #endregion
    }
}
