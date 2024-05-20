using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odyssey.Domain.Entities
{
    public interface ICreatable
    {
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
