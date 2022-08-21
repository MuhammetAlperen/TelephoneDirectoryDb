using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Entityes;

namespace TelephoneDirectory.Core.Context
{
    public class TelephoneDirectoryDbContext : DbContext
    {
        #region base(options)
        public TelephoneDirectoryDbContext(DbContextOptions<TelephoneDirectoryDbContext> options)
           : base(options)
        {

        }
        #endregion


        #region DbSet
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Person> person { get; set; }
        #endregion
    }
}
