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
    public class Person : EntityBase<int>
    {
        #region prop
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public int PhoneNo { get; set; }
        public int HomePhoneNo { get; set; }
        public int BusinessPhoneNo { get; set; }
        public string Note { get; set; }
        #endregion
    }
}
