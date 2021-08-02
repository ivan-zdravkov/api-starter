using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.DTOs
{
    public class ClassStudentsDTO : ClassDTO
    {
        public IEnumerable<StudentDTO> Students { get; set; }
    }
}
