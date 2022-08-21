using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Core.Entityes.Base
{
    public abstract class EntityBase<TId>
    {
        #region Prop.
        [Key]
        public TId Id { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public int? DeleteUserId { get; set; }
        public DateTime? DeleteDateTime { get; set; }
        public bool IsActive { get; set; }
        #endregion
    }
}
