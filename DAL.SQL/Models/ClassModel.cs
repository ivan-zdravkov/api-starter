using System.ComponentModel.DataAnnotations;
using Transport.Enums;
using Transport.Interfaces;

namespace DAL.SQL.Models
{
    public class ClassModel : Identifiable
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public int MaxSize { get; set; }
    }
}