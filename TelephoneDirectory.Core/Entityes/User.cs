using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Entityes.Base;

namespace TelephoneDirectory.Core.Entityes
{
    public class User : EntityBase<int>
    {
        #region prop
        public string UserName { get; set; }
        public string Password { get; set; }
        #endregion

    }
}
