using Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BaseEntity
{
    public class BaseEntity : IBaseEntity
    {
        public BaseEntity()
        {
            CreatedTime = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
