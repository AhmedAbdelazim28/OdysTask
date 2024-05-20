using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odyssey.Domain.Entities
{
    public class Course : BaseEntity<int> ,ICreatable ,IEditable
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(50)]
        public string DateOfBirth { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public int? LecturerId { get; set; }
        public virtual  Lecturer Lecturer { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
