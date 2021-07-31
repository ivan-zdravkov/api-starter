using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Interfaces;

namespace DAL.SQL.Models
{
    public class StudentModel : Identifiable
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
