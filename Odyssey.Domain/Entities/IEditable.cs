using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odyssey.Domain.Entities
{
    public interface IEditable
    {
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

    }
}
