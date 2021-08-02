using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.DTOs;

namespace Services.ViewModels
{
    public class StudentViewModel
    {
        //ToDo: Introduce AutoMapper
        public StudentViewModel(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public StudentViewModel(StudentDTO dto) : this(dto.Id, dto.Name) { }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
