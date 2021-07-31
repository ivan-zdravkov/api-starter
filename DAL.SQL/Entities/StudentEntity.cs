using DAL.SQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SQL.Entities
{
    public class StudentEntity : StudentModel
    {
        public List<ClassEntity> Classes { get; set; }
    }
}
