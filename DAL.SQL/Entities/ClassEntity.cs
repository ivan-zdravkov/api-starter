using DAL.SQL.Models;
using System.Collections.Generic;

namespace DAL.SQL.Entities
{
    public class ClassEntity : ClassModel, IBaseEntity
    {
        public List<StudentEntity> Students { get; set; }
    }
}