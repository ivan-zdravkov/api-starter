using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.DTOs
{
    public class ClassDTO : BaseDTO
    {
        public string Name { get; set; }

        public int MaxSize { get; set; }
    }
}
