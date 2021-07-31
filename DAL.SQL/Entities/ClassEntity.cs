using DAL.SQL.Models;
using System.Collections.Generic;

namespace DAL.SQL.Entities
{
    public class ClassEntity : ClassModel
    {
        public List<StudentEntity> Students { get; set; }
    }
}